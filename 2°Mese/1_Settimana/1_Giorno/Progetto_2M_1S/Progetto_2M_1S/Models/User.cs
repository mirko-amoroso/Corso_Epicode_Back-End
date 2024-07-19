namespace Progetto_2M_1S.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public string? FrinedlyName { get; set; }

        public List<string> Roles { get; set; } = [];

        public void ToString()
        {
            Console.WriteLine($"{Username} e {Password}");
        }

    }
}
