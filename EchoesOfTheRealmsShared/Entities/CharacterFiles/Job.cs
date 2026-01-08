using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.CharacterFiles
{

    [Index("Name", IsUnique = true)]

    public class Job
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int BonusHP { get; set; }

        [Required]
        public int BonusMana { get; set; }

        [Required]
        public int BonusStr { get; set; }

        [Required]
        public int BonusDex { get; set; }

        [Required]
        public int BonusIntel { get; set; }

        [Required]
        public int BonusLevel { get; set; }

        [Required]
        public int BonusVita { get; set; }

        [Required]
        public int BonusResFire { get; set; }

        [Required]
        public int BonusResIce { get; set; }

        [Required]
        public int BonusResLightning { get; set; }

        public string? Symbol { get; set; }

        public bool IsDeleted { get; set; }

        #region FK

        public int? CharacterId { get; set; }

        public Character? Character { get; set; } 

        #endregion

    }
}
