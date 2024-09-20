using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_D_D.Models.Entity
{
    public class Utente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UtenteId { get; set; }
        [Required, MaxLength(50)]
        public string NomeUtente { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string Password { get; set; }
        public ICollection<Personaggio>? Personaggio { get; set; }
    }
}
