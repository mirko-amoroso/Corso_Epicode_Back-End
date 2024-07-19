using Microsoft.Extensions.Configuration;
using Prog_S1_V.Interfacce;
using System.Data.Common;
using System.Data.SqlClient;

namespace Prog_S1_V.Service
{
    public abstract class Dao_SQL : AbstractDaoSQL
    {
        protected SqlConnection _connection;

        public Dao_SQL(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("AppDb"))!;
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
