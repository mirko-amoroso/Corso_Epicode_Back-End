//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();


using Progetto_2S_2G.Models;

namespace Progetto_2S_2G
{
    class Program
    {
        static void Main()
        {
            List<CV> lista_cv = new List<CV>();

            bool verifica = true;

            //info personali
            Console.WriteLine("SCRIVI LE TUE INFORMAZIONI PERSONALI:");
            Console.WriteLine("Scrivi il tuo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Scrivi il tuo cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Scrivi il tuo telefono: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Scrivi il tuo email: ");
            string email = Console.ReadLine();

            Console.WriteLine("INFORMZIONI STUDI E QUALIFICA: ");

            // studi

            List<Studi> lista_studi = new List<Studi>();
            while (verifica)
            {
                Console.WriteLine("Scrivi la tua qualifica: ");
                string qualifica = Console.ReadLine();
                if (string.IsNullOrEmpty(qualifica))
                    break;
                else
                {
                    Console.WriteLine("Scrivi il tuo istituto: ");
                    string istituto = Console.ReadLine();
                    Console.WriteLine("Scrivi il tuo tipo: ");
                    string tipo = Console.ReadLine();
                    Console.WriteLine("hai frequentato dal: ");
                    string dal = Console.ReadLine();
                    Console.WriteLine("hai frequentato al: ");
                    string al = Console.ReadLine();

                    Studi studiCurr = new Studi(qualifica, istituto, tipo, dal, al);
                    lista_studi.Add(studiCurr);
                    Console.WriteLine("Invia per andare avanti");
                }
            }
            ;

            //impiego

            List<esperienza> lista_esper = new List<esperienza>();
            while (verifica)
            {
                Console.WriteLine("Scrivi la tua azienda: ");
                string azienda = Console.ReadLine();
                Console.WriteLine("Scrivi jobtitle: ");

                if (string.IsNullOrEmpty(azienda))
                    break;
                else
                {
                    string jobtitle = Console.ReadLine();
                    Console.WriteLine("hai frequentato dal: ");
                    string dal = Console.ReadLine();
                    Console.WriteLine("hai frequentato al: ");
                    string al = Console.ReadLine();
                    Console.WriteLine("descrizione: ");
                    string descrizione = Console.ReadLine();
                    Console.WriteLine("compiti: ");
                    string compiti = Console.ReadLine();

                    esperienza esperienzaCurr = new esperienza(
                        azienda,
                        jobtitle,
                        dal,
                        al,
                        descrizione,
                        compiti
                    );

                    lista_esper.Add(esperienzaCurr);
                    Console.WriteLine("Invia per andare avanti");
                }
            }
            impieghi impiegoCurr = new impieghi(lista_esper);


            infoPerso infoCurr = new infoPerso(nome, cognome, telefono, email);

            CV curriculum = new CV(infoCurr, lista_studi, impiegoCurr);

            void visualizza(CV curriculum)
            {
                Console.WriteLine("+++++ INFORMAZIONI PERSONALI +++++");
                Console.WriteLine($"Nome: {curriculum.InformazioniPersonali.Nome}");
                Console.WriteLine($"Cognome: {curriculum.InformazioniPersonali.Cognome}");
                Console.WriteLine($"Telefono: {curriculum.InformazioniPersonali.Telefono}");
                Console.WriteLine($"Email: {curriculum.InformazioniPersonali.Email}");
                Console.WriteLine("+++++ STUDI E FORMAZIONE +++++");
                foreach (var item in curriculum.StudiEffettuati)
                {
                    Console.WriteLine($"Qualifica: {item.Qualifica}");
                    Console.WriteLine($"Istituto: {item.Istituto}");
                    Console.WriteLine($"Tipo: {item.Tipo}");
                    Console.WriteLine($"Dal: {item.Dal}");
                    Console.WriteLine($"Al: {item.Al}");
                }
                Console.WriteLine("+++++ ESPERIENZE PROFESSIONALI +++++");
                foreach (var item in curriculum.Impieghi.esperienze)
                {
                    Console.WriteLine($"nome: {item.Azienda}");
                    Console.WriteLine($"nome: {item.JobTitle}");
                    Console.WriteLine($"nome: {item.Dal}");
                    Console.WriteLine($"nome: {item.Al}");
                    Console.WriteLine($"nome: {item.Descrizione}");
                    Console.WriteLine($"nome: {item.Compiti}");
                }
            }
            visualizza(curriculum);
        }
    }
}
