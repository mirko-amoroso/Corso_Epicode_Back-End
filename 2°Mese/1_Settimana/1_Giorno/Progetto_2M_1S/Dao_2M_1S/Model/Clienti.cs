using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_2M_1S.Model
{
    public class Clienti
    {
        public int IdClienti { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Cognome")]
        public string? Cognome { get; set; }
        [Display(Name = "IsPrivate")]
        public bool IsPrivate { get; set; }
        [Display(Name = "Eta")]
        public int? Eta { get; set; }
        [Display(Name = "Cf")]
        public string? Cf { get; set; }
        [Display(Name = "P_Iva")]
        public string? P_Iva { get; set; }
    }
}
