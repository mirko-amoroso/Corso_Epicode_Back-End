using Progetto_2M_1S.Models;
using Microsoft.AspNetCore.Mvc;
using Progetto_2M_1S.Service;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Dao_2M_1S;
using Dao_2M_1S.Model;


namespace Progetto_2M_1S.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceBase _ServiceBase;
        private readonly IClientiDao _ClientiDao;
        private readonly IOrdiniDao _OrdiniDao;
        

        public HomeController(ILogger<HomeController> logger,IServiceBase servicebase, IClientiDao ClientiDao, IOrdiniDao ordini)
        {
            _logger = logger;
            _ServiceBase = servicebase;
            _ClientiDao = ClientiDao;
            _OrdiniDao = ordini;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult AllClienti()
        {
            var clienti = _ClientiDao.GetAllClienti();
            return View(clienti);
        }
        public IActionResult BottoneElimina(int id)
        {
            _ClientiDao.EliminaClienti(id);
            return RedirectToAction("AllClienti");
        }

        public IActionResult Form() 
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult BottoneForm(Dao_2M_1S.Model.Clienti clienti)
        {
            if (clienti.IsPrivate)
            {
                _ClientiDao.AddClientiPrivato(clienti);
            }
            else
            {
                _ClientiDao.AddClientiAzienda(clienti);
            }
            return Redirect("AllClienti");
        }


        public IActionResult Ordine()
        {
            var ordine = _OrdiniDao.GetAllOrdini();
            return View(ordine);
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
