namespace progetto_S3_G4.Models
{
    public class Impiegato
    {
        public int IdImpiegato { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string CodiceFiscale { get; set; }
        public int Eta { get; set; }
        public decimal RedditoMensile { get; set; }
        public bool DetrazioneFiscale { get; set; }
    }
}
