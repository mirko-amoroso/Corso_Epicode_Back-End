using Microsoft.AspNetCore.Mvc;
using progetto_2S_3G.Models;
using System.Diagnostics;

namespace progetto_2S_3G.Controllers
{
    public class HomeController : Controller
    {
        public static List<Utente> listaUtenti = new List<Utente>();

        Sala salaNord = new Sala();
        Sala salaSud = new Sala();
        Sala salaEst = new Sala();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Form()
        {
            //ViewBag.sale = ["salaEst","salaNord","salaSud"]
            var person = new Utente();  
            return View(person);
        }


        public IActionResult RiempiForm(Utente u) 
        {
            return View(listaUtenti);  
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
