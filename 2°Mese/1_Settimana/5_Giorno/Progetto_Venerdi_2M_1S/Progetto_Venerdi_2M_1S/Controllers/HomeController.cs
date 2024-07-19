using Microsoft.AspNetCore.Mvc;
using Progetto_Venerdi_2M_1S.Models;
using System.Diagnostics;
using Prog_S1_V.Interfacce;
using Prog_S1_V.Model;
using Prog_S1_V.Service;

namespace Progetto_Venerdi_2M_1S.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVerbaleDao _VerbaleDao;
        private readonly ITrasgressoreDao _TrasgressoreDao;
        private readonly ILogger<HomeController> _logger;
        private readonly TipoViolazioneDao _tipoViolazione;


        public HomeController(ILogger<HomeController> logger, IVerbaleDao verbale, ITrasgressoreDao Trasgressore, TipoViolazioneDao typeViolazione)
        {
            _logger = logger;
            _VerbaleDao = verbale;
            _TrasgressoreDao = Trasgressore;
            _tipoViolazione = typeViolazione;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllVerbali()
        {
            var verbali = _VerbaleDao.GetAllVerbaliTrasgressore();
            return View(verbali);
        }
        public IActionResult AllVerbaliSum()
        {
            var verbaliSum = _VerbaleDao.GetAllVerbaliTrasgressoreSum();
            return View(verbaliSum);
        }

        public IActionResult AllVerbaliOverTen()
        {
            var verbaliOverTen = _VerbaleDao.GetAllOverTen();
            return View(verbaliOverTen);
        }

        public IActionResult AllVerbaliOverFour()
        {
            var verbaliOverFour = _VerbaleDao.GetAllOverFour();
            return View(verbaliOverFour);
        }

        //****************************************************
        public IActionResult AllTrasgehssori()
        {
            var Trasgressori = _TrasgressoreDao.GetAllTrasgressori();
            return View(Trasgressori);
        }

        //****************************************************

        public IActionResult FormTrasgressori()
        {
            return View();
        }

        public IActionResult BottoneForm(Anagrafica tizio)
        {
            _TrasgressoreDao.WriteTrasgressori(tizio);
            return Redirect("AllTrasgehssori") ;
        }

        //****************************************************

        public IActionResult FormVerbale()
        {
            IEnumerable<Prog_S1_V.Model.TipoViolazione> ListaViolazioni = _tipoViolazione.getAllViolazione();
            Console.WriteLine(ListaViolazioni);
            ViewBag.Violazioni = ListaViolazioni;
            return View();
        }

        public IActionResult BottoneFormVerbale(Verbale verb)
        {
            _VerbaleDao.WriteVerbale(verb);
            return Redirect("AllTrasgehssori");
        }


        public IActionResult BottoneScgliTragressore(int id)
        {
            ViewBag.IdTizio = id;
            return RedirectToAction("FormVerbale");
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
