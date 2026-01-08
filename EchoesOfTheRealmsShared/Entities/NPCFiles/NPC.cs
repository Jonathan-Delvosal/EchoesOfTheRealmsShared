using EchoesOfTheRealmsShared.Entities.ItemFiles;
using EchoesOfTheRealmsShared.Entities.QuestFiles;
using System.ComponentModel.DataAnnotations;


namespace EchoesOfTheRealmsShared.Entities.NPCFiles
{
    public class NPC
    {

        [Key]
        public long Id { get; set; }

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string Identity { get; set; } = null!;

        [Required]
        public string Personnality { get; set; } = null!;

        [Required]
        public string Knownledge { get; set; } = null!;

        [Required]
        public string Behavior { get; set; } = null!;

        [Required]
        public string Limit { get; set; } = null!;

        public string Resume { get; set; } = null!;

        [Required]
        public string StyleLangage { get; set; } = null!;

        [Required]
        public int Gold { get; set; }

        public bool IsDeleted { get; set; }

        #region FK

        public Quest? Quest { get; set; }

        [Required]
        public int NpcRoleId { get; set; }

        public NPCRole NPCRole { get; set; } = null!;

        #endregion

    }
}
