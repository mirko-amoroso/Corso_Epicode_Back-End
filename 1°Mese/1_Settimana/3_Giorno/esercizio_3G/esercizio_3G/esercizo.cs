using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_3G
{
    internal class Esercizio
    {
        private string[] Lista;

        public Esercizio(string[] lista)
        {
            Lista = lista;
        }


        public void Cerca(string parola)
        {
            parola = parola.ToLower();
            for (int i = 0; i < Lista.Length; i++)
            {
                Lista[i] = Lista[i].ToLower();
            }
            foreach (string s in Lista) 
            {
                if (s == parola)
                {
                    Console.WriteLine($"si è presente la parola {parola}");
                }
            }
        }
    }
}
