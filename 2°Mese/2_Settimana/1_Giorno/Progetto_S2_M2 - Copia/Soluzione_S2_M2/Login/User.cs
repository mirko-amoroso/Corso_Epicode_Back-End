using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Login
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
