using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class PrenotazioniServizi
    {
        public int IdPrenServ { get; set; }
        [Display(Name = "IdServizio")]
        public int IdServizio { get; set; }
        [Display(Name = "IdPrenotazione")]
        public int IdPrenotazione { get; set; }
        [Display(Name = "DataInizio"), Required(ErrorMessage = "Inserci l'inizio del servizio")]
        public required DateTime DataInizio { get; set; }
        [Display(Name = "DataFine"),Required(ErrorMessage = "Inserci la fine del servizio")]
        public required DateTime DataFine { get; set; }
        [Display(Name = "Quantita"), Required(ErrorMessage = "Inserci quante persone usufruiscono del servizio")]
        public required int Quantita { get; set; }
    }
}
