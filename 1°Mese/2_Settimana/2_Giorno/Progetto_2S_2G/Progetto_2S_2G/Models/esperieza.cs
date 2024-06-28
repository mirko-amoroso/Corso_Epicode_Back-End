namespace Progetto_2S_2G.Models
{
    public class esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }

        public esperienza(
            string azienda,
            string jobTitle,
            string dal,
            string al,
            string descrizione,
            string compiti
        )
        {
            Azienda = azienda;
            JobTitle = jobTitle;
            Dal = dal;
            Al = al;
            Descrizione = descrizione;
            Compiti = compiti;
        }
    }
}
