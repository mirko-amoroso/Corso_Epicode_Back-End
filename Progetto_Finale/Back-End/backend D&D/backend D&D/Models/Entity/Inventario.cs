using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Inventario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventarioId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Effetto { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
