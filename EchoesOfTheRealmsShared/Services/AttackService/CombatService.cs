using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO.Attack;
using EchoesOfTheRealmsShared.Entities.AttackFiles;
using EchoesOfTheRealmsShared.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Services.AttackService
{
    public class CombatService(EotRContext _db)
    {
        // Variance -10%..+10%
        private const double VarianceMin = -0.10;
        private const double VarianceMax = 0.10;

        public AttackResultDTO ResolveAttack(AttackRequestDTO req)
        {
            // 1) Charger l'attaque (seulement)
            Attacks atk = _db.Attacks
                .AsNoTracking()
                .FirstOrDefault(a => a.Id == req.AttackId)
                ?? throw new Exception("Attack not found");

            // 2) Mana check
            if (req.Attacker.Mana < atk.ManaCost)
            {
                return new AttackResultDTO
                {
                    Success = false,
                    ErrorCode = "NOT_ENOUGH_MANA",
                    Damage = 0,
                    IsCrit = false,
                    VariancePercent = 0,
                    ManaSpent = 0,
                    AttackerHpAfter = req.Attacker.HP,
                    AttackerManaAfter = req.Attacker.Mana,
                    DefenderHpAfter = req.Defender.HP,
                    DefenderKo = req.Defender.HP <= 0
                };
            }

            // 3) AttackStat (Primary + Secondary * weight)
            double primary = GetStat(req.Attacker, atk.PrimaryStat);

            double secondary = 0;
            if (atk.SecondaryStat.HasValue)
                secondary = GetStat(req.Attacker, atk.SecondaryStat.Value);

            double attackStat = primary + (secondary * atk.SecondaryWeight);

            // 4) BaseDamage
            double baseDamage = attackStat * atk.Multiplier;

            // 5) Mitigation (Defense ou Resistance)
            double afterMitigation = atk.DefenseTarget switch
            {
                DefenseTargetType.Defense => ApplyDefense(baseDamage, req.Defender.DefenseTotal),

                DefenseTargetType.Resistance => ApplyResistance(
                    baseDamage,
                    GetResistanceByDamageType(req.Defender, atk.DamageTypeId)
                ),

                _ => baseDamage
            };

            // 6) Variance (-10%..+10%) avant crit
            double variance = NextDouble(VarianceMin, VarianceMax);
            double afterVariance = afterMitigation * (1.0 + variance);

            if (afterVariance < 0) afterVariance = 0; // sécurité

            // 7) Crit
            bool isCrit = false;
            double afterCrit = afterVariance;

            if (atk.CanCrit)
            {
                isCrit = RollCrit(req.Attacker.CritChanceTotal);
                if (isCrit)
                    afterCrit *= req.Attacker.CritMultiplierTotal;
            }

            // 8) Arrondi + min 1
            int damageFinal = RoundToInt(afterCrit);
            if (damageFinal < 1) damageFinal = 1;

            // 9) Appliquer au state "après"
            int attackerManaAfter = req.Attacker.Mana - atk.ManaCost;
            int defenderHpAfter = Math.Max(0, req.Defender.HP - damageFinal);

            return new AttackResultDTO
            {
                Success = true,
                ErrorCode = null,
                Damage = damageFinal,
                IsCrit = isCrit,
                VariancePercent = variance,
                ManaSpent = atk.ManaCost,
                AttackerHpAfter = req.Attacker.HP,
                AttackerManaAfter = attackerManaAfter,
                DefenderHpAfter = defenderHpAfter,
                DefenderKo = defenderHpAfter <= 0
            };
        }

        private static double GetStat(ActorResolvedDTO a, StatType stat) => stat switch
        {
            StatType.Str => a.StrTotal,
            StatType.Dex => a.DexTotal,
            StatType.Intel => a.IntelTotal,
            _ => 0
        };

        private static double ApplyDefense(double dmg, int defense)
        {
            if (dmg <= 0) return 0;
            if (defense < 0) defense = 0; // garde-fou
            return dmg * (100.0 / (100.0 + defense));
        }

        private static double ApplyResistance(double dmg, int resPercent)
        {
            if (dmg <= 0) return 0;
            return dmg * (1.0 - (resPercent / 100.0));
        }

        private static int GetResistanceByDamageType(ActorResolvedDTO defender, int damageTypeId) => damageTypeId switch
        {
            2 => defender.ResFireEffective,
            3 => defender.ResIceEffective,
            4 => defender.ResLightningEffective,
            _ => 0 // si type inconnu => pas de résistance
        };

        private static int RoundToInt(double x)
        {
            // x positif attendu; on arrondit au plus proche, 0.5 => +1
            if (x <= 0) return 0;
            return (int)Math.Floor(x + 0.5);
        }

        private static bool RollCrit(double critChance)
        {
            if (critChance >= 1.0) return true;
            if (critChance <= 0.0) return false;

            // Random cryptographique (anti-triche / stable)
            double roll = NextDouble(0.0, 1.0);
            return roll < critChance;
        }

        private static double NextDouble(double min, double max)
        {
            // RandomNumberGenerator.GetInt32 donne un int uniforme.
            // On convertit en double uniforme [0,1).
            int value = RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue);
            double unit = (value - (double)int.MinValue) / ((double)uint.MaxValue + 1.0);
            return min + (unit * (max - min));
        }
    }
}
