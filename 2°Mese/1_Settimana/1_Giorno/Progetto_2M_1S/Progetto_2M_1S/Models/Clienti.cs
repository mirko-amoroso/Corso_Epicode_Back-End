namespace Progetto_2M_1S.Models
{
    public class Clienti
    {
        
        public int IdClienti { get; set; }
        public string Nome { get; set; }
        public string? Cognome { get; set; }
        public bool IsPrivate { get; set; }
        public int? Eta { get; set; }
        public string? Cf { get; set; }
        public string? P_Iva { get; set; }

    }
}
