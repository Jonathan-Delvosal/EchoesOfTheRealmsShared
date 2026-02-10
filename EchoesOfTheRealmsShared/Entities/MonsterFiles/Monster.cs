using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.ItemFiles;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.MonsterFiles
{
    public class Monster
    {

        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int HP { get; set; }

        [Required]
        public int Mana { get; set; }

        [Required]
        public int Str { get; set; }

        [Required]
        public int Dex { get; set; }

        [Required]
        public int Intel { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public int Vita { get; set; }

        [Required]
        public double CritChance { get; set; }
        
        [Required]
        public double CritMultiplier { get; set; }

        [Required]
        public int Defense { get; set; }

        [Required]
        public int ResFire { get; set; }

        [Required]
        public int ResIce { get; set; }

        [Required]
        public int ResLightning { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }
        
        [Required]
        public int XPGiven { get; set; }

        [Required]
        public int GoldGiven { get; set; }

        #region FK
        [Required]
        public int MonsterTypeId { get; set; }
        public MonsterType MonsterType { get; set; } = null!;

        public List<Item> Items { get; set; } = null!;

        public List<Equipment> Equipment { get; set; } = null!;

        #endregion

    }

}
