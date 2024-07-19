using System.Data.Common;
using System.Data.SqlClient;

namespace Progetto_2M_1S.Service
{
    public class ServiceSQL : AbstractSQL
    {
        private SqlConnection _connection;
        public ServiceSQL(IConfiguration configuration)
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
