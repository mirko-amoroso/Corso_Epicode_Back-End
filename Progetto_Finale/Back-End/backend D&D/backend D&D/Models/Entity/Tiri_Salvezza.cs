using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Tiri_Salvezza
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiriSalvezzaId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        public bool Forza {  get; set; }
        public bool Destrezza { get; set; }
        public bool Costituzione { get; set; }
        public bool Saggezza { get; set; }
        public bool Intelligenza { get; set; }
        public bool Carisma { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
