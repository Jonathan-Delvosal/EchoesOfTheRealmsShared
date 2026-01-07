using System.ComponentModel.DataAnnotations;
using EchoesOfTheRealmsShared.Entities.QuestFiles;


namespace EchoesOfTheRealmsShared.Entities.NPCFiles
{
    public class NPC
    {

        [Key]
        public long Id { get; set; }

        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string Personnality { get; set; } = null!;

        public string Knownledge { get; set; } = null!;

        public string Resume { get; set; } = null!;

        public string StyleLangage { get; set; } = null!;

        public int Gold { get; set; }

        public bool IsDeleted { get; set; }

        #region FK

        public Quest? Quest { get; set; }

        #endregion

    }
}
