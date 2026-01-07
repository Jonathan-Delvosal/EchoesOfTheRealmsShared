namespace EchoesOfTheRealmsShared.Entities.ItemFiles
{
    public class ItemType
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        #region FK

        public List<Item> Items { get; set; } = null!;

        #endregion
    }
}
