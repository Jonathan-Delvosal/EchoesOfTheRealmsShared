using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.ItemFiles;
using EchoesOfTheRealmsShared.Entities.NPCFiles;
using System.ComponentModel.DataAnnotations;


namespace EchoesOfTheRealmsShared.Entities.QuestFiles
{
    public class Quest
    {

        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public bool Success { get; set; }

        public bool Failure { get; set; }

        public int LvlPrerequisites { get; set; }

        [Required]
        public int XPGiven { get; set; }

        [Required]
        public int GoldGiven { get; set; }

        public bool IsDeleted { get; set; }

        #region FK

        // FK id npc en cas de 1/1
        public long NpcId { get; set; } // la valeur etait en int

        public NPC Npc { get; set; } 

        // en cas de 0/n ou 1/n
        public List<Character> Characters { get; set; } = null!;

        // en cas de 0/1
        public Item? Item { get; set; }

        public Equipment? Equipment { get; set; }


        #endregion

    }
}
