using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proggetto_1g
{
    internal class Atleta
    {
        string name = "";
        string surname = "";
        string sport = "";

        public string Nome { get { return name; } set { name = value; } }
        public string Cognome { get { return surname; } set { surname = value; } }
        public string Sport { get { return sport; } set { sport = value; } }

        public void descriviti()
        {
            Console.WriteLine(
                "ciao sono " + this.Nome + " " +  this.Cognome +
                " faccio il " + this.Sport +
                " e la mia mossa preferita è il casché");
        }
    }
}
