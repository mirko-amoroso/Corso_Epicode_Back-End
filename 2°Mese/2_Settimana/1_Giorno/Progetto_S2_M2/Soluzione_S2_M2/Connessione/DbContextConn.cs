using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Connessione
{
    public class DbContextConn
    {
        public IAuthService _Auth { get; set; }
        public IServiceCamereDao CamereDao { get; set; }
        public IServiceClientDao ClientiDao { get; set; }
        public IServicePrenotazioneDao PrenotazioniDao { get; set; }
        public IServiceServiziDao ServiziDao { get; set; }

        public DbContextConn(IAuthService Auth, IServiceCamereDao _CamereDao, IServiceClientDao _ClientiDao, IServicePrenotazioneDao _prenotazioniDao, IServiceServiziDao _serviziDao)
        {
            _Auth = Auth;
            CamereDao = _CamereDao;
            ClientiDao = _ClientiDao;
            PrenotazioniDao = _prenotazioniDao;
            ServiziDao = _serviziDao;
        }
    }
}
