using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.DTO
{
    public class PCSheetResolvedDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }

        // Courant (persisté)
        public int HP { get; set; }
        public int Mana { get; set; }

        // Totaux calculés
        public int HpMaxTotal { get; set; }
        public int ManaMaxTotal { get; set; }

        public int StrTotal { get; set; }
        public int DexTotal { get; set; }
        public int IntelTotal { get; set; }
        public int VitaTotal { get; set; }

        public int DefenseTotal { get; set; }
        public double CritChanceTotal { get; set; }
        public double CritMultiplierTotal { get; set; }

        // Résistances totales
        public int ResFireTotal { get; set; }
        public int ResIceTotal { get; set; }
        public int ResLightningTotal { get; set; }

        // Caps joueur
        public int ResCapMin { get; set; } = -70;
        public int ResCapMax { get; set; } = 70;

        // Résistances effectives (capées)
        public int ResFireEffective { get; set; }
        public int ResIceEffective { get; set; }
        public int ResLightningEffective { get; set; }

        // Progression
        public int Lvl { get; set; }
        public int XP { get; set; }
        public int XpToNextLevel { get; set; }
        public int Gold { get; set; }

        // UI
        public int JobId { get; set; }
        public JobDTO? Job { get; set; }

        public EquipmentDTO? Helmet { get; set; }
        public EquipmentDTO? Armor { get; set; }
        public EquipmentDTO? Boot { get; set; }
        public EquipmentDTO? Weapon { get; set; }
    }
}
