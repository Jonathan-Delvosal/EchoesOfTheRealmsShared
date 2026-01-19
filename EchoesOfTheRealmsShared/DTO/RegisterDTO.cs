using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.DTO
{
    public class RegisterDTO
    {

        [Required]
        public string NickName { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Mail { get; set; } = null!;

    }
}
