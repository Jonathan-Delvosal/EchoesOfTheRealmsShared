using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Entities.NPCFiles
{
    public class NPCRole
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        #region FK

        public List<NPC> Npcs { get; set; } = null!;



        #endregion

    }
}
