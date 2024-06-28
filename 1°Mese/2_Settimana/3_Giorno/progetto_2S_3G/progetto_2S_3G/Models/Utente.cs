using System.ComponentModel.DataAnnotations;

namespace progetto_2S_3G.Models
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
