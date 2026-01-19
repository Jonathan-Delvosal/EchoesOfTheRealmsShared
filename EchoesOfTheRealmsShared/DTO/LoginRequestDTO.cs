using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealmsAPI.DTO
{
    public class LoginRequestDTO
    {

        [Required]
        public required string Username { get; set; }

        [Required]
        public required string Password { get; set; }

    }
}
