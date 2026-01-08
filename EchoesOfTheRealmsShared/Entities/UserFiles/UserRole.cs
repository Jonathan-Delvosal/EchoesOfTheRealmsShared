using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.UserFiles
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        #region FK

        public List<User> Users { get; set; } = null!;
        #endregion
    }
}
