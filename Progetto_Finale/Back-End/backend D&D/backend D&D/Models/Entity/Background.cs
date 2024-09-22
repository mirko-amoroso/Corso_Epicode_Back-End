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
        public string BackGround { get; set; }
        [Required]
        public string TrattiCaratteriali { get; set; }
        [Required]
        public string Ideali { get; set; }
        [Required]
        public string Legami { get; set; }
        [Required]
        public string Difetti { get; set; }
        [Required]
        public string Allineamento { get; set; }
        //public Personaggio? Personaggio { get; set; }

    }
}
