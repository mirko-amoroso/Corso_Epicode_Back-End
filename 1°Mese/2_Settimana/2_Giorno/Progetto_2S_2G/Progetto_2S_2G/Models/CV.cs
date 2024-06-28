namespace Progetto_2S_2G.Models
{
    public class CV
    {
        public infoPerso InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public impieghi Impieghi { get; set; }

        public CV(infoPerso infoPerso_1, List<Studi> Lista_Studi, impieghi impieghi_1 )
        {
            InformazioniPersonali = infoPerso_1;
            StudiEffettuati = Lista_Studi; ;
            Impieghi = impieghi_1;
        }
    }
}
