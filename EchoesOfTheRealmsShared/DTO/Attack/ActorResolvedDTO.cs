using EchoesOfTheRealmsShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.DTO.Attack
{
    public class ActorResolvedDTO
    {
        public ActorType Type { get; set; }
        public long Id { get; set; }

        // Etat courant combat (local, pas DB)
        public int HP { get; set; }
        public int Mana { get; set; }

        // Totaux calculés
        public int StrTotal { get; set; }
        public int DexTotal { get; set; }
        public int IntelTotal { get; set; }

        public int DefenseTotal { get; set; }

        public double CritChanceTotal { get; set; }
        public double CritMultiplierTotal { get; set; }

        // Résistances effectives (déjà capées)
        public int ResFireEffective { get; set; }
        public int ResIceEffective { get; set; }
        public int ResLightningEffective { get; set; }
    }
}
