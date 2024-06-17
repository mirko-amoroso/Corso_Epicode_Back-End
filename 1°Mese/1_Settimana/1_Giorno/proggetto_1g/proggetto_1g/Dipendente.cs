using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proggetto_1g
{
    internal class Dipendente
    {
        string name = "";
        string surname = "";
        string work = "";

        public string Nome { get { return name; } set { name = value; } }
        public string Cognome { get { return surname; } set { surname = value; } }
        public string Work { get { return work; } set { work = value; } }

        public void descriviti() { 
        Console.WriteLine(
                "ciao sono " + this.Nome + " " +  this.Cognome +
                " faccio il " + this.Sport +
                " e la mia mossa preferita è il casché");
        }
    }
}
