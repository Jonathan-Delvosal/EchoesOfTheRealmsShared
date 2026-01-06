using EchoesOfTheRealms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Entities
{
    public class Boot : Equipment
    {

        public List<Character> Characters { get; set; } = null!;

    }
}
