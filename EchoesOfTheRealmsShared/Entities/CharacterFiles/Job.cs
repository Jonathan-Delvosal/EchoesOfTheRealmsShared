using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.CharacterFiles
{

    [Index("Name", IsUnique = true)]

    public class Job
    {

        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; } = null!;

        public int BonusHP { get; set; }

        public int BonusMana { get; set; }

        public int BonusStr { get; set; }

        public int BonusDex { get; set; }

        public int BonusIntel { get; set; }

        public int BonusLevel { get; set; }

        public int BonusVita { get; set; }

        public int BonusResFire { get; set; }

        public int BonusResIce { get; set; }

        public int BonusResLightning { get; set; }

        public string? Symbol { get; set; }

        public bool IsDeleted { get; set; }

        #region FK

        public int? CharacterId { get; set; }

        public Character? Character { get; set; } 

        #endregion

    }
}
