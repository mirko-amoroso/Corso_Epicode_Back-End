using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Interfacce
{
    public interface IServiceCamereDao
    {
        public IEnumerable<Camere> GetAllCamere();
    }
}
