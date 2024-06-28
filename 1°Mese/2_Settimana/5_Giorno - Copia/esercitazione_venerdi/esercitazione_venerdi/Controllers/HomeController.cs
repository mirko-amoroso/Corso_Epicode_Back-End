using esercitazione_venerdi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace esercitazione_venerdi.Controllers
{
    public class HomeController : Controller
    {
        static List<Scarpe> listScarpe = new List<Scarpe>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Form()
        {
            var scarpa = new Scarpe();
            scarpa.Id = listScarpe.Count;
            return View(scarpa);
        }

        public IActionResult returnForm()
        {
            return View(listScarpe);
        }

        [HttpPost]
        public  IActionResult returnForm(Scarpe scarpa)
        {
            listScarpe.Add(scarpa);

            string baseDirectory = Directory.GetCurrentDirectory();

            // Definisci il nome della directory "wwwroot"
            string wwwrootDirectory = "wwwroot";

            // Combina il percorso della directory di base con il nome della directory "wwwroot"
            string wwwrootPath = Path.Combine(baseDirectory, wwwrootDirectory);

            string upload = Path.Combine(wwwrootPath, "images");
            Console.WriteLine(wwwrootPath);
            string filePath = Path.Combine(wwwrootPath, scarpa.Id.ToString());
            string file = Path.ChangeExtension(filePath, "jpg");
            using Stream fileStream = new FileStream(file, FileMode.Create);
            
            scarpa.img_1.CopyTo(fileStream);
        
            return RedirectToAction(nameof(Index)) ;
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
