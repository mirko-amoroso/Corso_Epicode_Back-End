    using System;

namespace Esercizio_4G
{
    internal class User
    {
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private DateTime oraAccesso;
        public DateTime OraAccesso
        {
            get { return oraAccesso; }
            set { oraAccesso = value; }
        }

        private bool loggato = false;
        public bool Loggato
        {
            get { return loggato; }
            set { loggato = value; }
        }

        public void MenuInizialeStart()
        {
            Console.WriteLine("\nScegli l'operazione da effettuare:");
            Console.WriteLine("1. LOGIN");
            Console.WriteLine("2. LOGOUT");
            Console.WriteLine("3. VERIFICA DATA E ORA LOGIN");
            Console.WriteLine("4. LISTA DEGLI ACCESSI");
            Console.WriteLine("5. ESCI");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                Login();
            }
            else if (scelta == 2)
            {
                Logout();
            }
            else if (scelta == 3)
            {
                DataOra();
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Chiusura programma in corso");
            }
            else if (scelta == 5)
            {
                Console.WriteLine("Uscita dal programma");
                return; // Esce dal programma
            }
            else
            {
                Console.WriteLine("Hai selezionato una voce non valida.");
                MenuInizialeStart();
            }
        }

        private void Login()
        {
            Console.WriteLine("Username: ");
            string UserName = Console.ReadLine();

            Console.WriteLine("Password: ");
            string PassWord = Console.ReadLine();

            Console.WriteLine("Conferma Password: ");
            string Conferma_PassWord = Console.ReadLine();

            if (
                !string.IsNullOrEmpty(PassWord)
                && !string.IsNullOrEmpty(Conferma_PassWord)
                && !string.IsNullOrEmpty(UserName)
                && PassWord == Conferma_PassWord
            )
            {
                Password = PassWord;
                Username = UserName;
                OraAccesso = DateTime.Now; // Imposta l'ora di accesso
                Loggato = true;

                Console.WriteLine($"Account creato da {Username}, aperto correttamente");
                MenuInizialeStart();
            }
            else
            {
                Console.WriteLine("Non Loggato");
                MenuInizialeStart();
            }
        }

        private void Logout()
        {
            if (Loggato)
            {
                Loggato = false;
                Console.WriteLine($"{Username}, hai effettuato il logout");
            }
            else
            {
                Console.WriteLine("Errore: non sei loggato");
            }
            MenuInizialeStart();
        }

        private void DataOra()
        {
            if (Loggato)
            {
                Console.WriteLine($"Accesso effettuato il: {OraAccesso}");
            }
            else
            {
                Console.WriteLine("Errore: non sei loggato");
            }
            MenuInizialeStart();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User ();
            user.MenuInizialeStart();
        }
    }
}