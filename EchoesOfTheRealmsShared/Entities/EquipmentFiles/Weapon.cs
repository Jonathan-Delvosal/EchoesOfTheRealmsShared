using EchoesOfTheRealmsShared.Entities.CharacterFiles;

namespace EchoesOfTheRealmsShared.Entities.EquipmentFiles
{
    public class Weapon : Equipment
    {

        public List<Character> Characters {  get; set; } = null!;

    }
}
