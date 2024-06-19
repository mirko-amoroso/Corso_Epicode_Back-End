using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_3G
{
    internal class ContoCorrente
    {
        private int Conto;

        public ContoCorrente(int conto)
        {
            if (conto >= 1000)
            {
                Conto = conto;
                Console.WriteLine($"conto creato con successo: sono stati aggiunti {conto}");
            }
            else
            {
                conto = 1000;
                Console.WriteLine(
                    "il tuo conto non può essere inferiore a 1000€ sono stati accreditati 1000€"
                );
            }
        }

        public void prelievo(int soldi)
        {
            if (this.Conto >= soldi)
            {
                this.Conto -= soldi;
                Console.WriteLine($"ti sono rimasti {this.Conto}€");
            }
            else
            {
                Console.WriteLine($"nel tuo conto hai {this.Conto}€");
            }
        }

        public void versamento(int soldi)
        {
            this.Conto += soldi;
            Console.WriteLine($"nel tuo conto hai {this.Conto}€");
        }
    }
}
