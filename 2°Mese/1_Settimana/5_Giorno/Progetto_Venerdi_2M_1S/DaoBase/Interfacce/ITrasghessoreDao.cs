using Prog_S1_V.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Interfacce
{
    public interface ITrasgressoreDao
    {
        public IEnumerable<Anagrafica> GetAllTrasgressori();
        public void WriteTrasgressori(Anagrafica Trasgressori);
    }
}
