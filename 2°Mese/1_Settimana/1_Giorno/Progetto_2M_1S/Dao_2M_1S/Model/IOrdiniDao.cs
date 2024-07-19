using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_2M_1S.Model
{
    public interface IOrdiniDao
    {
        public IEnumerable<Ordini> GetAllOrdini();
    }
}
