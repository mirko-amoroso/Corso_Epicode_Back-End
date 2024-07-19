using Progetto_2M_1S.Models;

namespace Progetto_2M_1S.Service
{
    public interface IServiceBase
    {
        public IEnumerable<Clienti> GetAllClienti();

        public IEnumerable<Ordini> AllOrdini();
    }
}
