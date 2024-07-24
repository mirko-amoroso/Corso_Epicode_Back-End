using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Interfacce
{
    public interface IServiceClientDao
    {
        public IEnumerable<Clienti> GetAllClienti();
        public IEnumerable<UPrenotazioniCliente> GetAllPrenotazioniById(Clienti clienti);
        public Clienti GetByCodFisc(string cod);
        public void CreaFormClient(Clienti C);
    }
}
