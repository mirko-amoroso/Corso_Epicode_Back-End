using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class Clienti
    {
        public int IdCliente { get; set; }
        public required string Nome { get; set; }
        public string Cod_Fisc { get; set; }
        public required string Cognome { get; set; }
        public required string Citta { get; set; }
        public required string Provincia { get; set; }
        public string Email { get; set; }
        public required string Telefono { get; set; }
    }
}
