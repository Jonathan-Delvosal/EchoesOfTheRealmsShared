using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.ItemFiles;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.MonsterFiles
{
    public class Monster
    {

        [Key]
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public int HP { get; set; }

        public int Mana { get; set; }

        public int Str { get; set; }

        public int Dex { get; set; }

        public int Intel { get; set; }

        public int Level { get; set; }

        public int Vita { get; set; }

        public int ResFire { get; set; }

        public int ResIce { get; set; }

        public int ResLightning { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }
        
        public int XPGiven { get; set; }

        public int GoldGiven { get; set; }

        #region FK
        public int MonsterTypeId { get; set; }
        public MonsterType MonsterType { get; set; } = null!;

        public List<Item> Items { get; set; } = null!;

        public List<Equipment> Equipment { get; set; } = null!;

        #endregion

    }
}
