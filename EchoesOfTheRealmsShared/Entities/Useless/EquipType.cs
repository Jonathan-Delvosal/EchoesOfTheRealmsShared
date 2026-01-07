namespace EchoesOfTheRealmsShared.Entities.Useless
{
    public class EquipType
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Equipment> Equipment { get; set; } = null!;
    }
}
