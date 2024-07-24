using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class Clienti
    {
        public int IdCliente { get; set; }
        [Display(Name = "Nome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Immetti il Nome")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Devi inserire un minimo di 2 caratteri e un massimo di 30")]
        public required string Nome { get; set; }
        [Display(Name = "Cod_Fisc")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Immetti il Codice fisclae")]
        [StringLength(16,MinimumLength =16, ErrorMessage ="Devi inserire 16 caratteri")]
        public string Cod_Fisc { get; set; }
        [Display(Name = "Cognome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Immetti il Cognome")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Devi inserire un minimo di 2 caratteri e un massimo di 30")]
        public required string Cognome { get; set; }
        [Display(Name = "Citta"), Required(ErrorMessage ="Inserisci la citta dove abiti")]
        public required string Citta { get; set; }
        [Display(Name = "Provincia"), Required(ErrorMessage = "Inserisci la tua Provincia")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Devi inserire 2 caratteri")]
        public required string Provincia { get; set; }
        [Display(Name = "Email"), Required(ErrorMessage = "Inserisci la tua Email")]
        public string Email { get; set; }
        [Display(Name = "Telefono"), Required(ErrorMessage = "Inserisci la tua Telefono")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Devi inserire 11 caratteri")]
        public required string Telefono { get; set; }
    }
}
