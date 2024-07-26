using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class UPrenotazioneServizi : PrenotazioniServizi
    {
        public int IdServizio { get; set; }
        public string Descrizione { get; set; }
        public decimal Costo { get; set; }
    }
}
