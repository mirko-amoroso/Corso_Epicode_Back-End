using backend_D_D.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_D_D.Models
{
    public class JoinPersonaggiClassi : Personaggio
    {
        public int ClassiId { get; set; }
        public int Livello { get; set; }
        public int TipoClasse { get; set; }
    }
}
