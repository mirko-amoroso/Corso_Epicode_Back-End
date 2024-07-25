using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class Servizi
    {
        public int IdServizio { get; set; }
        [Display(Name = "Descrizione"), Required(ErrorMessage = "Inserisci la descrione del servizio")]
        public string Descrizione { get; set; }
        [Display(Name = "Costo"), Required(ErrorMessage = "Inserisci il costo del servizio")]
        public decimal Costo { get; set; }
    }
}
