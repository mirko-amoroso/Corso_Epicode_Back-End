using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Service
{
    public class ServicePrenotazioneDao : ServiceSql, IServicePrenotazioneDao
    {
        public ServicePrenotazioneDao(IConfiguration configuration) : base(configuration)
        {
        }

        public void CreaFormPreno(Prenotazioni P)
        {
            throw new NotImplementedException();
        }
    }
}
