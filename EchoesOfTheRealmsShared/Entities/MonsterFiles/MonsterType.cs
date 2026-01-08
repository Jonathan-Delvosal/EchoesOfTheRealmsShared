using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.MonsterFiles
{

    [Index("Name", IsUnique = true)]

    public class MonsterType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        #region FK

        public List<Monster> Monsters { get; set; } = null!;


        #endregion

    }
}
