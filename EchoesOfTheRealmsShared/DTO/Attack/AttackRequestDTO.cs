using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.DTO.Attack
{
    public class AttackRequestDTO
    {
        public int AttackId { get; set; }

        public ActorResolvedDTO Attacker { get; set; } = null!;
        public ActorResolvedDTO Defender { get; set; } = null!;
    }
}
