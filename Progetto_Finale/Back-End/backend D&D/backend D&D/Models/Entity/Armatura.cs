using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Armatura
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArmaturaId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        public string Nome { get; set; }
        public int CA { get; set; }
        public string Effetto { get; set; }
        public bool Indossato { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
