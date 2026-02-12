using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Rules;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Mappers
{
    public static class MapperExtension
    {
        public static MonsterScreenResponseDTO Map(this Monster m)
        {
            return new MonsterScreenResponseDTO
            {
                Id = m.Id,
                Name = m.Name,
                Type = m.MonsterType.Name,
                Hp = m.HP,
                Mana = m.Mana,
                Level = m.Level,
                Str = m.Str,
                Dex = m.Dex,
                Intel = m.Intel,
                Vita = m.Vita,
                ResFire = m.ResFire,
                ResIce = m.ResIce,
                ResLightning = m.ResLightning,
                Defense = m.Defense,
                CritChance = m.CritChance,
                CritMultiplier = m.CritMultiplier,
                XpGiven = m.XPGiven,
                GoldGiven = m.GoldGiven

            };
        }

        public static PCSheetDTO Map(this Character c)
        {

            return new PCSheetDTO
            {
                Id = c.Id,
                Name = c.Name,
                HP = c.HP,
                HPMax = c.HPMax,
                Mana = c.Mana,
                ManaMax = c.ManaMax,
                Str = c.Str,
                StrMax = c.StrMax,
                Dex = c.Dex,
                DexMax = c.DexMax,
                Intel = c.Intel,
                IntelMax = c.IntelMax,
                Vita = c.Vita,
                VitaMax = c.VitaMax,
                ResFire = c.ResFire,
                ResFireMax = c.ResFireMax,
                ResIce = c.ResIce,
                ResIceMax = c.ResIceMax,
                ResLightning = c.ResLightning,
                ResLightningMax = c.ResLightningMax,
                Defense = c.Defense,
                CritChance = c.CritChance,
                CritMultiplier = c.CritMultiplier,
                Lvl = c.LvL,
                XP = c.XP,
                Gold = c.Gold,
                JobId = c.JobId,
                Job = c.Job.Map(),
                Weapon = c.Weapon?.Map(),
                Helmet = c.Helmet?.Map(),
                Armor = c.Armor?.Map(),
                Boot = c.Boot?.Map(),

            };

        }

        public static JobDTO Map(this Job j)
        {

            return new JobDTO
            {
                Id = j.Id,
                Name = j.Name,
                BonusLevel = j.BonusLevel,
                BonusHP = j.BonusHP,
                BonusMana = j.BonusMana,
                BonusStr = j.BonusStr,
                BonusDex = j.BonusDex,
                BonusIntel = j.BonusIntel,
                BonusResFire = j.BonusResFire,
                BonusResIce = j.BonusResIce,
                BonusResLightning = j.BonusResLightning,
                BonusVita = j.BonusVita,
                BonusDefense = j.BonusDefense,
                BonusCritChance = j.BonusCritChance,
                BonusCritMultiplier = j.BonusCritMultiplier,

            };

        }

        public static EquipmentDTO Map(this Equipment e)
        {
            return new EquipmentDTO
            {
                Id = e.Id,
                IdCustom = e.IdCustom,
                EquipType = e.Type.Name,
                MaterialType = e.MaterialType.Name,
                Name = e.Name,
                Description = e.Description,
                FlavorText = e.FlavorText,
                ModHP = e.ModHP,
                ModMana = e.ModMana,
                ModStr = e.ModStr,
                ModDex = e.ModDex,
                ModIntel = e.ModIntel,
                ModLvl = e.ModLVL,
                ModVita = e.ModVita,
                ModResFire = e.ModResFire,
                ModResIce = e.ModResIce,
                ModResLightning = e.ModResLightning,
                BuyPrice = e.BuyPrice,
                SellPrice = e.SellPrice,
                ModDefense = e.ModDefense,
                ModCritChance = e.ModCritChance,
                ModCritMultiplier = e.ModCritMultiplier,

            };

        }

        public static PCSheetResolvedDTO MapResolved(this Character c)
        {
            var job = c.Job;

            var equipped = new List<Equipment>();
            if (c.Weapon != null) equipped.Add(c.Weapon);
            if (c.Helmet != null) equipped.Add(c.Helmet);
            if (c.Armor != null) equipped.Add(c.Armor);
            if (c.Boot != null) equipped.Add(c.Boot);

            int sumHp = equipped.Sum(e => e.ModHP ?? 0);
            int sumMana = equipped.Sum(e => e.ModMana ?? 0);

            int sumStr = equipped.Sum(e => e.ModStr ?? 0);
            int sumDex = equipped.Sum(e => e.ModDex ?? 0);
            int sumIntel = equipped.Sum(e => e.ModIntel ?? 0);
            int sumVita = equipped.Sum(e => e.ModVita ?? 0);

            int sumResFire = equipped.Sum(e => e.ModResFire ?? 0);
            int sumResIce = equipped.Sum(e => e.ModResIce ?? 0);
            int sumResLightning = equipped.Sum(e => e.ModResLightning ?? 0);

            int sumDefense = equipped.Sum(e => e.ModDefense ?? 0);

            double sumCritChance = equipped.Sum(e => e.ModCritChance ?? 0.0);
            double sumCritMult = equipped.Sum(e => e.ModCritMultiplier ?? 0.0);

            int hpMaxTotal = c.HPMax + job.BonusHP + sumHp;
            int manaMaxTotal = c.ManaMax + job.BonusMana + sumMana;

            int strTotal = c.Str + job.BonusStr + sumStr;
            int dexTotal = c.Dex + job.BonusDex + sumDex;
            int intelTotal = c.Intel + job.BonusIntel + sumIntel;
            int vitaTotal = c.Vita + job.BonusVita + sumVita;

            int defenseTotal = c.Defense + job.BonusDefense + sumDefense;
            double critChanceTotal = c.CritChance + job.BonusCritChance + sumCritChance;
            double critMultiplierTotal = c.CritMultiplier + job.BonusCritMultiplier + sumCritMult;

            int resFireTotal = c.ResFire + job.BonusResFire + sumResFire;
            int resIceTotal = c.ResIce + job.BonusResIce + sumResIce;
            int resLightningTotal = c.ResLightning + job.BonusResLightning + sumResLightning;

            const int capMin = -70;
            const int capMax = 70;

            int resFireEff = Clamp(resFireTotal, capMin, capMax);
            int resIceEff = Clamp(resIceTotal, capMin, capMax);
            int resLightningEff = Clamp(resLightningTotal, capMin, capMax);

            return new PCSheetResolvedDTO
            {
                Id = c.Id,
                Name = c.Name,

                HP = c.HP,
                Mana = c.Mana,

                HpMaxTotal = hpMaxTotal,
                ManaMaxTotal = manaMaxTotal,

                StrTotal = strTotal,
                DexTotal = dexTotal,
                IntelTotal = intelTotal,
                VitaTotal = vitaTotal,

                DefenseTotal = defenseTotal,
                CritChanceTotal = critChanceTotal,
                CritMultiplierTotal = critMultiplierTotal,

                ResFireTotal = resFireTotal,
                ResIceTotal = resIceTotal,
                ResLightningTotal = resLightningTotal,

                ResCapMin = capMin,
                ResCapMax = capMax,

                ResFireEffective = resFireEff,
                ResIceEffective = resIceEff,
                ResLightningEffective = resLightningEff,

                Lvl = c.LvL,
                XP = c.XP,
                XpToNextLevel = XpTable.GetXpToNextLevel(c.LvL),
                Gold = c.Gold,

                JobId = c.JobId,
                Job = job.Map(),

                Weapon = c.Weapon?.Map(),
                Helmet = c.Helmet?.Map(),
                Armor = c.Armor?.Map(),
                Boot = c.Boot?.Map()
            };
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }

}
