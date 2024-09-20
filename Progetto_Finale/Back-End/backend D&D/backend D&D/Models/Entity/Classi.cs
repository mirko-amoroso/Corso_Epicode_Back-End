using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Classi
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassiId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        [Required]
        public int Livello { get; set; }
        [Required]
        public string TipoClasse { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
