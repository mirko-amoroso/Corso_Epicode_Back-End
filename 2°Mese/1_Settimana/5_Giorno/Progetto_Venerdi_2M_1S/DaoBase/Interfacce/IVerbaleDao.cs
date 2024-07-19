using Prog_S1_V.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Interfacce
{
    public interface IVerbaleDao
    {
        public IEnumerable<Verbale> GetAllVerbali();
        public IEnumerable<Anagrafica_Verbale> GetAllVerbaliTrasgressore();
        public Anagrafica_Verbale CreaVerbale_Anagrafe(DbDataReader reader);
        public IEnumerable<Anagrafica_Verbale> GetAllVerbaliTrasgressoreSum();
        public IEnumerable<Anagrafica_Verbale> GetAllOverTen();
        public IEnumerable<Anagrafica_Verbale> GetAllOverFour();
        public void WriteVerbale(Verbale verb);


    }
}
