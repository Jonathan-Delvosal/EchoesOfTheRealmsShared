using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Entities.AttackFiles
{
    public class MonsterAttacks
    {
        public long MonsterId { get; set; }
        public Monster Monster { get; set; } = null!;

        public int AttackId { get; set; }
        public Attacks Attack { get; set; } = null!;

        public int Weight { get; set; }
    }
}
