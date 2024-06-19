using esercizio_3G;

namespace Progetto_3G
{
    class Program
    {

        static void Main(string[] args)
        {
            Esercizio array = new Esercizio(["MirKo", "GIAcomo", "sarA", "aNDReE"]);
            array.Cerca("giacomo");
        }
    }
}