namespace Progetto_2S_2G.Models
{
    public class Studi
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }

        public Studi(string qualifica, string istituto, string tipo, string dal, string al)
        {
            Qualifica = qualifica;
            Istituto = istituto;
            Tipo = tipo;
            Dal = dal;
            Al = al;
        }

    }
}
