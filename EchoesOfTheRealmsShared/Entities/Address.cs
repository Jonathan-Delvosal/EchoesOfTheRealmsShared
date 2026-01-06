using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Address
    {

        [Key]
        public int Id { get; set; }

        public string Street { get; set; } = null!;

        public int Number { get; set; }

        public int NumberBox { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        #region FK 
        public int CustomerId { get; set; }
        
        public User Customer { get; set; } = null!;


        #endregion


    }
}
