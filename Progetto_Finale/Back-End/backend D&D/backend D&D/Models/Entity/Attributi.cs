using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Attributi
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttributiId { get; set; }
        [ForeignKey("Personaggio"), Required]

        public int PV { get; set; }
        public int PersonaggioID { get; set; }
        public int Forza { get; set; }
        public int Destrezza { get; set; }
        public int Costituzione { get; set; }
        public int Saggezza { get; set; }
        public int Intelligenza { get; set; }
        public int Carisma { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
