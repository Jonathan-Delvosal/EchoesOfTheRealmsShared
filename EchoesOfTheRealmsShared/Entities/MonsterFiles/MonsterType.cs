using Microsoft.EntityFrameworkCore;

namespace EchoesOfTheRealmsShared.Entities.MonsterFiles
{

    [Index("Name", IsUnique = true)]

    public class MonsterType
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        #region FK

        public List<Monster> Monsters { get; set; } = null!;


        #endregion

    }
}
