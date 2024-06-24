var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//using progetto_S2_G1.Models;

//namespace progetto_S2_G1
//{
//    class Program
//    {
//        static void Main()
//        {
//            Alimento coca_cola = new Alimento("coco-cola", 2.50);

//            coca_cola.AlimentoMenu("1");

//            Alimento insalata_pollo = new Alimento("insalta di pollo", 5.20);

//            insalata_pollo.AlimentoMenu("2");

//            Alimento pizza_margherita = new Alimento("pizza margherita", 10.00);

//            pizza_margherita.AlimentoMenu("3");

//            Alimento pizza_4_formaggi = new Alimento("pizza 4 formaggi", 12.50);

//            pizza_4_formaggi.AlimentoMenu("4");

//            Alimento patatine_fritte = new Alimento("patatine fritte", 3.50);

//            patatine_fritte.AlimentoMenu("5");

//            Alimento insalata_di_riso = new Alimento("insalata di riso", 8.00);

//            insalata_di_riso.AlimentoMenu("6");

//            Alimento frutta_di_stagione = new Alimento("frutta di stagione", 5.00);

//            frutta_di_stagione.AlimentoMenu("7");

//            Alimento pizza_fritta = new Alimento("pizza fritta", 5.00);

//            pizza_fritta.AlimentoMenu("8");

//            Alimento piadina_vegetariana = new Alimento("piadina vegetariana", 6.00);

//            piadina_vegetariana.AlimentoMenu("9");

//            Alimento panino_hamburger = new Alimento("panino hamburger", 7.90);

//            panino_hamburger.AlimentoMenu("10");

//            Ordinazione ordinazione = new Ordinazione();


//            bool attivatore = true;
//            while (attivatore)
//            {
//                string risposta = Console.ReadLine();
//                switch (risposta)
//                {
//                    case "1":
//                        ordinazione.aggiungi(coca_cola);
//                        break;
//                    case "2":
//                        ordinazione.aggiungi(insalata_pollo);
//                        break;
//                    case "3":
//                        ordinazione.aggiungi(pizza_margherita);
//                        break;
//                    case "4":
//                        ordinazione.aggiungi(pizza_4_formaggi);
//                        break;
//                    case "5":
//                        ordinazione.aggiungi(patatine_fritte);
//                        break;
//                    case "6":
//                        ordinazione.aggiungi(insalata_di_riso);
//                        break;
//                    case "7":
//                        ordinazione.aggiungi(frutta_di_stagione);
//                        break;
//                    case "8":
//                        ordinazione.aggiungi(pizza_fritta);
//                        break;
//                    case "9":
//                        ordinazione.aggiungi(piadina_vegetariana);
//                        break;
//                    case "10":
//                        ordinazione.aggiungi(panino_hamburger);
//                        break;
//                    case "11":
//                        ordinazione.finale();
//                        attivatore = false;
//                        break;
//                    default:
//                        attivatore = true;
//                        break;


//                }
//            }
//        }
//    }
//}
