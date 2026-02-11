using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Entities.AttackFiles
{
    public  class JobAttacks
    {

        public int JobId { get; set; }

        public Job Job { get; set; } = null!;

        public int AttackId { get; set; }

        public Attacks Attack { get; set; } = null!;

        [Required]

        public int RequiredLevel { get; set; } = 1;
    }
}
