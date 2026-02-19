using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.DTO.Attack
{
    public class AttackResultDTO
    {
        public bool Success { get; set; }
        public string? ErrorCode { get; set; } // ex: "NOT_ENOUGH_MANA"

        public int Damage { get; set; }
        public bool IsCrit { get; set; }

        // variance (utile debug / UI)
        public double VariancePercent { get; set; } // ex: -0.07 = -7%

        public int ManaSpent { get; set; }

        // état après (toujours renvoyé pour être raccord)
        public int AttackerHpAfter { get; set; }
        public int AttackerManaAfter { get; set; }
        public int DefenderHpAfter { get; set; }

        public bool DefenderKo { get; set; }
    }
}
