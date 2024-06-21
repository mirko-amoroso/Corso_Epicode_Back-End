using System.Reflection;

namespace Progetto_setimananle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInserisci il nome:");
            string nomeUten = Console.ReadLine();

            Console.WriteLine("\nInserisci il cognome:");
            string cognomeUten = Console.ReadLine();
            
            Console.WriteLine("\nInserisci la tua data di nascita:");
            string nascitaUten = Console.ReadLine();
            
            Console.WriteLine("\nInserisci il tuo codice fiscale:");
            string codicefiscle = Console.ReadLine();
            
            Console.WriteLine("\nInserisci genere: \n1.Maschio\n2.Femmina\n3.Altro");
            string genere = Console.ReadLine();
            string gender ="";
            try
            {
                int genereInt = int.Parse(genere);
                gender = myGenere(genereInt);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input non valido. Assicurati di inserire un numero tra 1 e 3.");
                Console.WriteLine($"Errore: {ex.Message}");
            }

            Console.WriteLine("\nInserisci il tuo comune di residenza:");
            string comuneRes = Console.ReadLine();

            Console.WriteLine("\nInserisci il tuo reddito annuo:");
            int redditoAnn = int.Parse(Console.ReadLine());

            int imposte = Contribuente.calcoloImposte(redditoAnn);

            Contribuente giacomo = new Contribuente(nomeUten, cognomeUten, nascitaUten, codicefiscle, gender, comuneRes, redditoAnn, imposte);

            giacomo.presetati();


        }

        enum Genere
        {
            m = 1,
            f = 2,
            nd = 3
        }

        static string myGenere(int gender)
        {
            if (gender == 1) return "M"; 
            if (gender == 2) return "F";
            else {  return "N.D."; }
        }

        

    }
}
