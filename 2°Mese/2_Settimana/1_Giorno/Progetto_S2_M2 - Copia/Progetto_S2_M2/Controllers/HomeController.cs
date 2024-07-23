using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Progetto_S2_M2.Models;
using Soluzione_S2_M2.Interfacce;
using System.Diagnostics;

namespace Progetto_S2_M2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceCamereDao CamereDao;
        private readonly IServiceClientDao ClientiDao;

        public HomeController(ILogger<HomeController> logger, IServiceCamereDao _CamereDao, IServiceClientDao _ClientiDao)
        {
            _logger = logger;
            CamereDao = _CamereDao;
            ClientiDao = _ClientiDao;
        }

        //[Authorize(Roles = "Amministratore, Master")]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult CodFisc()
        {
            var clienti = ClientiDao.GetAllClienti();
            return View("CodFisc", clienti);
        }

        [Authorize(Roles = "Amministratore, Master, Utente")]
        public IActionResult CamereHotel()
        {
            var tutteCamere = CamereDao.GetAllCamere();
            return View(tutteCamere);
        }

        [Authorize(Roles = "Master")]
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
