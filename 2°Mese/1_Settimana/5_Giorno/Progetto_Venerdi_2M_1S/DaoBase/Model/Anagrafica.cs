using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Model
{
    public class Anagrafica
    {
        public int IdAnagrafica { get; set; }
        [Display(Name = "Cognome")]
        public string Cognome { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Indirizzo")]
        public string Indirizzo { get; set; }
        [Display(Name = "Citta")]
        public string Citta { get; set; }
        [Display(Name = "CAP")]
        public string CAP { get; set; }
        [Display(Name = "Cod_Fisc")]
        public string Cod_Fisc { get; set; }

    }
}
