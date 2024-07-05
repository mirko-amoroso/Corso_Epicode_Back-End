using System.Data.Common;

namespace progetto_S3_G4.Service
{
    public class sqlService : ServiceBase
    {
        private sqlService _connect;

        public sqlService(sqlService config)
        {
            _connect = new sqlService(config.getConnection("DB"));
        }
        protected override DbConnection getConnection()
        {
            throw new NotImplementedException();
        }

        protected override DbCommand getCoommand(string Text)
        {
            throw new NotImplementedException();
        }
    }
}
