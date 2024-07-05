using System.Data.Common;

namespace progetto_S3_G4.Service
{
    public abstract class ServiceBase
    {
        protected abstract DbConnection getConnection();
        protected abstract DbCommand getCoommand(string Text);
            
    }
}
