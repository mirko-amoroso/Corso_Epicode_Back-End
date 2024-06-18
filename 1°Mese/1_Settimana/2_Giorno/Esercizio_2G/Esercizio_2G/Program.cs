using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esercizio_2G;

namespace esercizio_2G
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Persona persona_1 = new Persona("giacomo", "abiuso", 22);

            persona_1.getNome();
            persona_1.getCognome();
            persona_1.getEta();

            persona_1.getDetails();

            Console.WriteLine("il suo nome è: " + persona_1.Nome);
        }
    }
}