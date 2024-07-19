using System.Data.Common;

namespace Progetto_2M_1S.Service
{
    public abstract class AbstractSQL
    {
        protected abstract DbConnection GetConnection();
        protected abstract DbCommand GetCommand(string command);
    }
}
