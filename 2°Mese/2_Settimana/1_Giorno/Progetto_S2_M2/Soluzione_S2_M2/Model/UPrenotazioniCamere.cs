using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class UPrenotazioniCamere : Prenotazioni
    {
        public required int IdCamera { get; set; }
        public int NumCam { get; set; }
        public string Descrizione { get; set; }
        public bool Doppia { get; set; }

    }
}
