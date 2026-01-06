using Microsoft.EntityFrameworkCore;

namespace EchoesOfTheRealms.Entities
{

    [Index("Name", IsUnique = true)]

    public class MaterialType
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Equipment> Equipment { get; set; } = null!;
    }
}
