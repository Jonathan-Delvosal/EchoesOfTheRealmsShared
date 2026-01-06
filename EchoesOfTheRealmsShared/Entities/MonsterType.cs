using Microsoft.EntityFrameworkCore;

namespace EchoesOfTheRealms.Entities
{

    [Index("Name", IsUnique = true)]

    public class MonsterType
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Monster> Monsters { get; set; } = null!;
    }
}
