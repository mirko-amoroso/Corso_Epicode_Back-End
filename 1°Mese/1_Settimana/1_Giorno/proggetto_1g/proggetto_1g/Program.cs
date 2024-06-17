namespace proggetto_1g
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                Atleta GiacomoBall = new Atleta();

                GiacomoBall.Nome = "Giacomo";
                GiacomoBall.Cognome = "Abbiu";
                GiacomoBall.Sport = "Ballerino";

                GiacomoBall.descriviti();
            }

            {
                Dipendente GiacomoLav = new Dipendente();
                GiacomoLav.Nome = "Giacomo";
                GiacomoLav.Cognome = "Abbiu";
                GiacomoLav.Work = "Disuccupato (ma pagato)";

                GiacomoLav.descriviti();
            }
        }
    }
}
