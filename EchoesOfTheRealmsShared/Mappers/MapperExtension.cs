using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
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
                Gold = c.Gold

            };

        }
 
    }
    
}
