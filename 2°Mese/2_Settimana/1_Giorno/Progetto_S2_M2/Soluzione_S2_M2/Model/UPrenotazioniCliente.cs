using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class UPrenotazioniCliente : Clienti
    {
        public required int IdPrenotazioni { get; set; }
        public required DateTime DataPrenotazioni { get; set; }
        public required DateTime DataInizio { get; set; }
        public required DateTime DataFine { get; set; }
        public decimal Caparra { get; set; }
        public decimal Importo { get; set; }
        public bool MezzaPensione { get; set; }
        public bool PensioneCompleta { get; set; }
        public bool PernottamentoPrimaColazione { get; set; }
        public int IdCamera { get; set; }
        public int IdClienti { get; set; }
    }
}
