using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
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

            };

        }

    }

}
