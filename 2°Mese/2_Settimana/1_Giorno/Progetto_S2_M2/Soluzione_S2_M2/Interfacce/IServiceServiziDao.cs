using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Interfacce
{
    public interface IServiceServiziDao
    {
        public void CreaFormServizi(Servizi servizio);
        public void AddServizi(PrenotazioniServizi SGestione);
        public IEnumerable<Servizi> TuttiServizi();
       
    }
}
