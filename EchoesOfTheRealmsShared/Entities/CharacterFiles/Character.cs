using EchoesOfTheRealmsShared.Entities.EquipmentFiles;
using EchoesOfTheRealmsShared.Entities.ItemFiles;
using EchoesOfTheRealmsShared.Entities.QuestFiles;
using EchoesOfTheRealmsShared.Entities.UserFiles;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.CharacterFiles
{

    [Index("Name", IsUnique = true)]
    public class Character
    {

        [Key]
        public long Id { get; init; }

        [Required]
        public required string Name { get; set; }

        public int HP { get; set; }

        public int Mana { get; set; }

        public int Str { get; set; }

        public int Dex { get; set; }

        public int Intel { get; set; }

        public int Vita { get; set; }

        public int ResFire { get; set; }

        public int ResIce { get; set; }

        public int ResLightning { get; set; }

        public int LvL { get; set; }

        public int XP { get; set; }

        public int Gold { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }

        #region FK
        public int UserId { get; set; }
        
        public User User { get; set; } = null!;

        public int JobId { get; set; }
        
        public Job Job { get; set; } = null!;

        public List<Quest> Quests { get; set; } = null!;

        public List<Item> Items { get; set; } = null!;

        public List<Equipment> Equipments { get; set; } = null!;

        //public Weapon? Weapon { get; set; }
        //public long? WeaponId { get; set; }

        //public Helmet? Helmet { get; set; }
        //public long? HelmetId { get; set; }

        //public Armor? Armor { get; set; }
        //public long? ArmorId { get; set; }

        //public Boot? Boot { get; set; }
        //public long? BootId { get; set; }


        #endregion




    }
}
