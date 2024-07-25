using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class Prenotazioni
    {
        public required int IdPrenServ { get; set; }
        [Display(Name = "DataPrenotazioni")]
        public required DateTime DataPrenotazione { get; set; }
        [Display(Name = "DataInizio")]
        public required DateTime DataInizio { get; set; }
        [Display(Name = "DataFine")]
        public required DateTime DataFine { get; set; }
        [Display(Name = "Caparra"), Required(ErrorMessage = "Inserire il costo della caparra")]
        public decimal Caparra {  get; set; }
        [Display(Name = "Importo"), Required(ErrorMessage = "Inserire il costo dell'importo")]
        public decimal Importo { get; set; }
        [Display(Name = "MezzaPensione")]
        public bool MezzaPensione { get; set; }
        [Display(Name = "PensioneCompleta")]
        public bool PensioneCompleta { get; set; }
        [Display(Name = "PernottamentoPrimColazione")]
        public bool PernottamentoPrimaColazione { get; set; }
        [Display(Name = "IdCamere")]
        public int IdCamera { get; set; }
        [Display(Name = "IdClienti")]
        public int IdClienti { get; set; }
    }
}
