using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Progetto_S2_M2.Models;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;
using System.Diagnostics;

namespace Progetto_S2_M2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceCamereDao CamereDao;
        private readonly IServiceClientDao ClientiDao;
        private readonly IServicePrenotazioneDao PrenotazioniDao;

        public HomeController(ILogger<HomeController> logger, IServiceCamereDao _CamereDao, IServiceClientDao _ClientiDao, IServicePrenotazioneDao _prenotazioniDao)
        {
            _logger = logger;
            CamereDao = _CamereDao;
            ClientiDao = _ClientiDao;
            PrenotazioniDao = _prenotazioniDao;
        }

        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult Index()
        {
            ViewBag.clienti = ClientiDao.GetAllClienti();
            return View();
        }

        //********************************************************

        public IActionResult FormCliente()
        {

            return View();
        }

        public IActionResult BottoneSalvaCliente(Clienti cliente) 
        {
            ClientiDao.CreaFormClient(cliente);
            return RedirectToAction("Index");
        }

        //********************************************************

        public IActionResult FormPrenotazioni()
        {

            return View();
        }

        public IActionResult BottoneSalvaPrenotazione(Prenotazioni prenotazione, string TipoPensione)
        {
            switch (TipoPensione)
            {
                case "MezzaPensione":
                    prenotazione.MezzaPensione = true;
                    break;
                case "PensioneCompleta":
                    prenotazione.PensioneCompleta = true;
                    break;
                case "PernottamentoPrimaColazione":
                    prenotazione.PernottamentoPrimaColazione = true;
                    break;
            }
            return RedirectToAction("Index");
        }

        //********************************************************

        public IActionResult FormServizi()
        {

            return View();
        }

        //********************************************************

        [AllowAnonymous]
        public IActionResult CodiceFiscale(string codFisc)
        {
            ViewBag.clienti = ClientiDao.GetAllClienti();
            var c = ClientiDao.GetByCodFisc(codFisc);
            if (c == null)
            {
                return NotFound("Cliente non trovato");
            }
            var clienti = ClientiDao.GetAllPrenotazioniById(c);
            Console.WriteLine($"questi sono i clienti: {clienti.Count()}"); // Controlla il numero di prenotazioni
            foreach (var item in clienti)
            {
                Console.WriteLine($"Prenotazione: {item.IdPrenotazioni}, {item.DataPrenotazioni}, {item.Nome}");
            }

            return View(clienti);
        }

        //**********************************************************



        [Authorize(Roles = "Amministratore, Master, Utente")]
        public IActionResult CamereHotel()
        {
            ViewBag.clienti = ClientiDao.GetAllClienti();
            var tutteCamere = CamereDao.GetAllCamere();
            return View(tutteCamere);
        }
        //**********************************************************

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
