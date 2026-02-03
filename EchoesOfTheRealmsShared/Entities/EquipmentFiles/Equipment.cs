using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using EchoesOfTheRealmsShared.Entities.MonsterFiles;
using EchoesOfTheRealmsShared.Entities.QuestFiles;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.EquipmentFiles
{
    public class Equipment
    {

        [Key]
        public long Id { get; set; }

        public long IdCustom { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public string? FlavorText { get; set; }

        public int? ModHP { get; set; }

        public int? ModMana { get; set; }

        public int? ModStr { get; set; }

        public int? ModDex { get; set; }

        public int? ModIntel { get; set; }

        public int? ModLVL { get; set; }

        [Required]
        public int BuyPrice { get; set; }

        [Required]
        public int SellPrice { get; set; }

        public int? ModVita { get; set; }

        public int? ModResFire { get; set; }

        public int? ModResIce { get; set; }

        public int? ModResLightning { get; set; }

        public int LvLPrerequisites { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }

        #region FK
        [Required]
        public int TypeId { get; set; }

        public EquipType Type { get; set; } = null!;

        [Required]
        public int MaterialTypeId { get; set; }

        public MaterialType MaterialType { get; set; } = null!;


        public List<Quest> Quest { get; set; } = null!;

        public List<Character>? Characters { get; set; }

        public List<Monster> Monster { get; set; } = null!;
        #endregion

    }
}
