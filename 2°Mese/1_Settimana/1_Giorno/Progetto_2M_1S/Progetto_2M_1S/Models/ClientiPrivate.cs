using System.ComponentModel.DataAnnotations;

namespace Progetto_2M_1S.Models
{
    public class ClientiPrivate : Clienti
    {
        [Display(Name = "Cognome")]
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string Cf { get; set; }
    }
}
