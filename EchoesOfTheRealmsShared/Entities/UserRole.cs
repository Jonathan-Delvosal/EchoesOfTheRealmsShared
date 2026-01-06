namespace EchoesOfTheRealms.Entities
{
    public class UserRole
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        #region FK

        public List<User> Users { get; set; } = null!;
        #endregion
    }
}
