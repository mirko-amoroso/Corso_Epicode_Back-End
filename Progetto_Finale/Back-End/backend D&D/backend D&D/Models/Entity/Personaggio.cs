using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Personaggio
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaggioID { get; set; }
        [ForeignKey("Utente"), Required]
        public int IdUtente { get; set; }
        [Required, MaxLength(50)]
        public string Nome { get; set; }
        public Utente? Utente { get; set; }
        public ICollection<Armi>? Armi { get; set; }
        public ICollection<Armatura>? Armatura { get; set; }
        public ICollection<Inventario>? Inventario { get; set; }
        public Abilita? Abilita { get; set; }
        public Attributi? Attributi { get; set; }
        public Background? Backgound { get; set; }
        public ICollection<Classi>? Classi { get; set; }
        public Tiri_Salvezza? Tiri_Salvezza { get; set; }
    }
}
