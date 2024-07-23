using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Interfacce
{
    public abstract class IServiceSql
    {
        protected abstract DbConnection GetConnection();
        protected abstract DbCommand GetCommand(string command);
    }
}
