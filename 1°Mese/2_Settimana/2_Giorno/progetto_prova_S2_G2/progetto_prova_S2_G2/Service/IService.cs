using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_prova_S2_G2.Service
{
    public interface IService
    {
        public void aggiungi_infoPers(infoPers InfoPers);
        public void aggiungi_studi(studi_class Studi);
        public void esperienza(esperienza Esperienza);

        CVClass creaCV();
    }
}
