using Prog_S1_V.Interfacce;
using Prog_S1_V.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Collegamento
{
    public class DbContext
    {
        public IVerbaleDao _VerbaleDao { get; set; }
        public ITrasgressoreDao _TrasgressoreDao { get; set; }
        public TipoViolazioneDao _tipoViolazione { get; set; }


        public DbContext(IVerbaleDao verbal, ITrasgressoreDao Trasgressore, TipoViolazioneDao TypeViolazione)
        {
            _VerbaleDao = verbal;
            _TrasgressoreDao = Trasgressore;
            _tipoViolazione = TypeViolazione;
        }
    }
}
