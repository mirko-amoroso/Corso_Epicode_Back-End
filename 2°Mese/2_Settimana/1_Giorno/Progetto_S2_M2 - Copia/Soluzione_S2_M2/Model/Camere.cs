using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Model
{
    public class Camere
    {
        public required int IDCamera {  get; set; }
        public int NumCam { get; set; }
        public string Descrizione { get; set; }
        public bool Doppia { get; set; }

    }
}
