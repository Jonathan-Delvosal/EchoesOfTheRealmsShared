using EchoesOfTheRealmsShared.Entities.CharacterFiles;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsShared.Entities.UserFiles
{
    [Index("Mail", "NickName", IsUnique = true)]
    [Index("NickName", IsUnique = true)]
    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string NickName { get; set; } = null!;

        public string? Avatar { get; set; }

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string Mail { get; set; } = null!;

        public string Note { get; set; } = null!;

        public bool IsBanned { get; set; }

        public bool IsDeleted { get; set; }

        #region FK
        public Address? Address { get; set; } = null!;

        public List<UserRole> UserRoles { get; set; } = null!;

        public List<Character> Characters { get; set; } = null!;

        #endregion



    }
}
