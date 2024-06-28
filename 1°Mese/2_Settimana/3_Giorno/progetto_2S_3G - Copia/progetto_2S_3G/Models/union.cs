using System.ComponentModel.DataAnnotations;

namespace progetto_2S_3G.Models
{
    public class union
    {
        public Utente person { get; set; }
        [Display(Name = "nome_sala")]
        public string salaNome { get; set; }
    }
}
