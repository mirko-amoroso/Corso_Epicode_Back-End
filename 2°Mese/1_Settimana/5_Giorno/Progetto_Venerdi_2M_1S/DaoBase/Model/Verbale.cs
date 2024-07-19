using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Model
{
    public class Verbale
    {
        public int IdVerbale { get; set; }
        [Display(Name = "DataViolazione")]
        public DateTime DataViolazione { get; set;}
        [Display(Name = "IndirizzoViolazioen")]
        public string IndirizzoViolazione { get; set;}
        [Display(Name = "NominativoAgente")]
        public string NominativoAgente { get; set;}
        [Display(Name = "DataTrascrizioneVerbale")]
        public DateTime DataTrascrizioneVerbale {  get; set;}
        [Display(Name = "Importo")]
        public decimal Importo { get; set;}
        [Display(Name = "DecurtamentoPunti")]
        public int DecurtamentoPunti {  get; set;}
        [Display(Name = "IdAnagrafico")]
        public int IdAnagrafica { get; set;}
        [Display(Name = "IdViolazione")]
        public int IdViolazione { get; set;}
    }
}
