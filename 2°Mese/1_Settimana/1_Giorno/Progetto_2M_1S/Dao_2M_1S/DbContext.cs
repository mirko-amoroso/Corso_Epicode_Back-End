using Dao_2M_1S.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_2M_1S
{
    public class DbContext
    {
        public IClientiDao _clientiDao {  get; set; }
        public IOrdiniDao _ordiniDao { get; set; }

        public DbContext(IClientiDao Client, IOrdiniDao Order) 
        {
            _clientiDao = Client;
            _ordiniDao = Order;
        }
    }
}
