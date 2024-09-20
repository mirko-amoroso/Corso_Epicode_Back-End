using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend_D_D.Models.Entity
{
    public class Abilita
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AbilitaId { get; set; }
        [ForeignKey("Personaggio"), Required]
        public int PersonaggioID { get; set; }
        public bool Acrobazia { get; set; }
        public bool Addestrare_Animali { get; set; }
        public bool Arcano { get; set; }
        public bool Atletica { get; set; }
        public bool Furtivita { get; set; }
        public bool Indagare { get; set; }
        public bool Inganno { get; set; }
        public bool Intimidire { get; set; }
        public bool Intrattenere { get; set; }
        public bool Intuizione { get; set; }
        public bool Medicina { get; set; }
        public bool Natura { get; set; }
        public bool Percezione { get; set; }
        public bool Persuasione { get; set; }
        public bool Rapidita_di_Mano { get; set; }
        public bool Religione { get; set; }
        public bool Sopravvivenza { get; set; }
        public bool Storia { get; set; }
        //public Personaggio? Personaggio { get; set; }
    }
}
