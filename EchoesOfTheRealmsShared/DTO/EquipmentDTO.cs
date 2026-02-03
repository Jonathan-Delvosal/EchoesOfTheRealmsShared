using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.DTO
{
    public class EquipmentDTO
    {

        public long Id { get; set; }

        public long IdCustom { get; set; }

        public string? EquipType { get; set; }

        public string? MaterialType { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? FlavorText { get; set; }

        public int? ModHP { get; set; }

        public int? ModMana { get; set; }

        public int? ModStr { get; set; }

        public int? ModDex { get; set; }

        public int? ModIntel { get; set; }

        public int? ModLvl { get; set; }

        public int BuyPrice { get; set; }

        public int SellPrice { get; set; }

        public int? ModVita { get; set; }

        public int? ModResFire { get; set; }

        public int? ModResIce { get; set; }

        public int? ModResLightning { get; set; }

    }
}
