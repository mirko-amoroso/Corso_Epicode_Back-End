using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_2M_1S.Model
{
    public class Ordini
    {
        public int IdOrdine { get; set; }
        public int IdClienti { get; set; }
        public DateTime DataSpedizione { get; set; }
        public decimal Peso { get; set; }
        public string Citta { get; set; }
        public string IndirizzoDestinatrio { get; set; }
        public decimal CostoSpedizione { get; set; }
        public DateTime DataPrevista { get; set; }
    }
}
