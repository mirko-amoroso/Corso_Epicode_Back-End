using progetto_S3_G4.Models;

namespace progetto_S3_G4.Service
{
    public interface IImpiegato
    {
        void WriteImpiegato(Impiegato impiegato);
        Impiegato get_Impiegato(int id);
    }
}
