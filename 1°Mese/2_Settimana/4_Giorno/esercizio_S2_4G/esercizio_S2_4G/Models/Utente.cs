using System.ComponentModel.DataAnnotations;

namespace esercizio_S2_4G.Models
{
    public class Utente
    {
        [Display(Name ="Nome")]
        public string nome { get; set; }
        [Display(Name = "Cognome")]
        public string cognome { get; set; }
        [Display(Name ="Biglietto")]
        public bool biglietto { get; set; }

    }
}
