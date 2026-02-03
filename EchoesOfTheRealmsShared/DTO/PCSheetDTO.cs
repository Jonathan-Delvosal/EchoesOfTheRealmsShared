using System.Xml.XPath;

namespace EchoesOfTheRealmsShared.DTO
{
    public class PCSheetDTO
    {

        public long Id { get; set; }

        public string? Name { get; set; }

        public int HP { get; set; }

        public int HPMax { get; set; }

        public int Mana { get; set; }

        public int ManaMax { get; set; }

        public int Str {  get; set; }

        public int StrMax { get; set; }

        public int Dex { get; set; }

        public int DexMax { get; set; }

        public int Intel { get; set; }

        public int IntelMax { get; set; }

        public int Vita { get; set; }

        public int VitaMax { get; set; }

        public int ResFire { get; set; }

        public int ResFireMax { get; set; }

        public int ResIce { get; set; }

        public int ResIceMax { get; set; }

        public int ResLightning { get; set; }

        public int ResLightningMax { get; set; }

        public int Lvl { get; set; }

        public int XP { get; set; }

        public int Gold { get; set; }

        public int JobId { get; set; }

        public JobDTO? Job { get; set; }

        public EquipmentDTO? Helmet { get; set; }

        public EquipmentDTO? Armor { get; set; }

        public EquipmentDTO? Boot { get; set; }

        public EquipmentDTO? Weapon { get; set; }
    }
}
