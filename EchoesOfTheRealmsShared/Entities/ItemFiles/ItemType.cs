using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.ItemFiles
{
    public class ItemType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        #region FK

        public List<Item> Items { get; set; } = null!;

        #endregion
    }
}
