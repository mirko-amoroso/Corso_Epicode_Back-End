using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_2M_1S.Model
{
    public interface IClientiDao
    {
        public IEnumerable<Clienti> GetAllClienti();
        public Clienti CreaCliente(DbDataReader reader);

        public void EliminaClienti(int id);
        public void EliminaClienteOrdini(int id);
        public void AddClientiPrivato(Clienti cliente);
        public void AddClientiAzienda(Clienti cliente);
        
    }
}
