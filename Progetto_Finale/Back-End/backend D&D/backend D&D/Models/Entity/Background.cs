using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Background
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BackgroundId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        [Required]
        public int TrattiCaratteriali { get; set; }
        [Required]
        public int Ideali { get; set; }
        [Required]
        public int Legami { get; set; }
        [Required]
        public int Difetti { get; set; }
        [Required]
        public string Allineamento { get; set; }
        //public Personaggio? Personaggio { get; set; }

    }
}
