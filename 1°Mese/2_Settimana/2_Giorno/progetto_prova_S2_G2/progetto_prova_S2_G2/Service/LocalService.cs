using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_prova_S2_G2.Service
{
    public class LocalService : IService
    {
        CVClass CV = new CVClass();
        public void aggiungi_infoPers(infoPers InfoPersone)
        {
            CV.InfoPers = InfoPersone;
        }

        public void aggiungi_studi(studi_class Studi)
        {
            CV.listStud.Add(Studi);
        }

        public void esperienza(esperienza Esperienza)
        {
           CV.esperienza.Add(Esperienza);
        }
        public CVClass creaCV()
        {
            
        }
    }
}
