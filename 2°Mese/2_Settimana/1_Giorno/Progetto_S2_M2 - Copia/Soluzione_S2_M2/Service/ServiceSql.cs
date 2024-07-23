using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Interfacce;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Service
{
    public class ServiceSql : IServiceSql
    {
        private SqlConnection _connection;
        public ServiceSql(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("AppDb"));
        }
        protected override DbCommand GetCommand(string command)
        {
            return new SqlCommand(command, _connection);
        }

        protected override DbConnection GetConnection()
        {
            return _connection;
        }
    }
}
