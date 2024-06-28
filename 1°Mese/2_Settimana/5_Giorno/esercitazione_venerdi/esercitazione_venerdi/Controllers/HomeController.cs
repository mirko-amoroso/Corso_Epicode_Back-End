using System;
using System.Diagnostics;
using System.IO;
using esercitazione_venerdi.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult returnForm(Scarpe scarpa)
        {
            scarpa.path = $"/images/{scarpa.Id}a.jpg";
            scarpa.path_2 = $"/images/{scarpa.Id}b.jpg";
            scarpa.path_3 = $"/images/{scarpa.Id}c.jpg";
            listScarpe.Add(scarpa);

            // Ottieni il percorso della directory wwwroot
            string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            // Percorso della cartella "images" all'interno di wwwroot
            string uploadPath = Path.Combine(wwwrootPath, "images");

            // Percorso completo del file da salvare
            string filePath = Path.Combine(uploadPath, $"{scarpa.Id}a.JPG");
            string filePath_2 = Path.Combine(uploadPath, $"{scarpa.Id}b.JPG");
            string filePath_3 = Path.Combine(uploadPath, $"{scarpa.Id}c.JPG");

            // Crea il file e copia i contenuti di scarpa.img_1
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                scarpa.img_1.CopyTo(fileStream);
            }

            if (scarpa.img_2 != null)
                using (FileStream fileStream = new FileStream(filePath_2, FileMode.Create))
                {
                    scarpa.img_2.CopyTo(fileStream);
                }

            if (scarpa.img_3 != null)
                using (FileStream fileStream = new FileStream(filePath_3, FileMode.Create))
                {
                    scarpa.img_3.CopyTo(fileStream);
                }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Info (int info)
        {   Scarpe scar = new Scarpe();
            for (int i = 0; i < listScarpe.Count; i++)
            {
                if (listScarpe[i].Id == info)
                {
                    scar = listScarpe[i];
                }
            }
            return View(scar);
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
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
