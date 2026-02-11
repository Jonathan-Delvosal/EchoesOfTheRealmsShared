using EchoesOfTheRealmsShared.Entities.CharacterFiles;

namespace EchoesOfTheRealmsShared.Entities.EquipmentFiles
{
    public class Weapon : Equipment
    {

        public int WeaponTypeId { get; set; }

        public WeaponType WeaponType { get; set; } = null!;

    }
}
