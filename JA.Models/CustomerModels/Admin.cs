namespace JA.Models.CustomerModels
{
    public class Admin : Entity<Admin>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdminType { get; set; }
        public bool IsAdmin;
    }
}