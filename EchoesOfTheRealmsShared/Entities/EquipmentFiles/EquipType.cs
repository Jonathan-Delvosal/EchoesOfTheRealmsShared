using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.EquipmentFiles
{
    [Index("Name", IsUnique = true)]


    public class EquipType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public List<Equipment> Equipment { get; set; } = null!;
    }
}
