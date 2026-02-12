namespace EchoesOfTheRealmsShared.DTO
{
    public class MonsterScreenResponseDTO
    {

        public long Id { get; set; }

        public string Type { get; set; } = null!;

        public string Name { get; set; } = null!;

        public int Level { get; set; }

        public int Hp { get; set; }

        public int Mana { get; set; }

        public int Str { get; set; }

        public int Dex { get; set; }

        public int Intel { get; set; }

        public int Vita { get; set; }

        public int ResFire { get; set; }

        public int ResIce { get; set; }

        public int ResLightning { get; set; }

        public int Defense { get; set; }

        public double CritChance { get; set; }

        public double CritMultiplier { get; set; }

        public int XpGiven { get; set; }

        public int GoldGiven { get; set; }
    }
}
