using esercizio_S2_4G.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace esercizio_S2_4G
{
    public class HomeController : Controller
    {
        public static List<Utente> listaUtenti = new List<Utente>();



        static Sala salaNord = new Sala("salaNord");
        static Sala salaSud = new Sala("salaSud");
        static Sala salaEst = new Sala("salaOvest");



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Form()
        {
            ViewBag.sale = new List<Sala> { salaNord, salaEst, salaSud };
            var person = new Utente();
            return View(person);
        }


        public IActionResult RiempiForm(Utente u, string stringaSala)
        {
            if (stringaSala == "salaEst")
                salaEst.UtenteList.Add(u);
            else if (stringaSala == "salaSud")
                salaSud.UtenteList.Add(u);
            else
                { salaNord.UtenteList.Add(u); }

            List<Sala> insieme_sale = new List<Sala> {salaNord, salaEst, salaSud};
            

            return View(insieme_sale);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
