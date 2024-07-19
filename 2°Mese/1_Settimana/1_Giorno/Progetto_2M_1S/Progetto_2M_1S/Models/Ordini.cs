namespace Progetto_2M_1S.Models
{
    public class Ordini
    {
        public int IdOrdine { get; set; }
        public int IdClienti { get; set;}
        public DateTime DataSpedizione { get; set; }
        public decimal Peso {  get; set; }
        public string Citta { get; set; }
        public string IndirizzoDestinatrio { get; set; }
        public decimal CostoSpedizione { get; set; }
        public DateTime DataPrevista { get; set; }

    }
}
