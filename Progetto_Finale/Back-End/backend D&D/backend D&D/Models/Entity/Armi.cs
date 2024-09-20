using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Armi
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArmaId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Danno { get; set; }
        public string BonusArma { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
