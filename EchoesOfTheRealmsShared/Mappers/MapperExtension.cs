using EchoesOfTheRealmsShared.DTO;
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
 
    }
    
}
