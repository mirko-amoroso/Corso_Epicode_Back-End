using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Interfacce
{
    public abstract class AbstractDaoSQL
    {
        protected abstract DbConnection GetConnection();
        protected abstract DbCommand GetCommand(string command);
    }
}
