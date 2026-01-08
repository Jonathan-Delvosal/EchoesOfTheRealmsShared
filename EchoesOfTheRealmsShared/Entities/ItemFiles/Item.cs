using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Entities.QuestFiles;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.ItemFiles
{
    public class Item
    {

        [Key]
        public long Id { get; set; }

        public long IdCustom { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public string FlavorText { get; set; } = null!;

        [Required]
        public string? Effect { get; set; }

        [Required]
        public int BuyPrice { get; set; }

        [Required]
        public int SellPrice { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }

        #region FK

        public List<Quest> Quest { get; set; } = null!;

        public List<Character> Characters { get; set; } = null!;

        public List<Monster> Monsters { get; set; } = null!;

        [Required]
        public int ItemTypeId { get; set; }

        public ItemType ItemType { get; set; } = null!;

        #endregion
    }
}
