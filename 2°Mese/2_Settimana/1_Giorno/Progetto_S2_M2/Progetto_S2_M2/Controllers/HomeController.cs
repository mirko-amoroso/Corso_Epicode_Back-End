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
        private readonly IServiceServiziDao ServiziDao;

        public HomeController(ILogger<HomeController> logger, IServiceCamereDao _CamereDao, IServiceClientDao _ClientiDao, IServicePrenotazioneDao _prenotazioniDao, IServiceServiziDao _serviziDao)
        {
            _logger = logger;
            CamereDao = _CamereDao;
            ClientiDao = _ClientiDao;
            PrenotazioniDao = _prenotazioniDao;
            ServiziDao = _serviziDao;
        }

        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult Index()
        {
            ViewBag.clienti = ClientiDao.GetAllClienti();
            return View();
        }

        //********************************************************

        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult FormCliente()
        {

            return View();
        }
        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult BottoneSalvaCliente(Clienti cliente, int IdCliente) 
        {
            ClientiDao.CreaFormClient(cliente);
            return RedirectToAction("Index");
        }

        //********************************************************
        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult ClientiAll() 
        {
            var tuttiClienti = ClientiDao.GetAllClienti();
            return View(tuttiClienti);
        }

        public IActionResult RedirectFormPrenotazioni(int IdCliente)
        {
            return RedirectToAction("FormPrenotazioni", new { IdCliente });
        }


        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult FormPrenotazioni(int IdCliente)
        {
            ViewBag.camere = CamereDao.GetAllCamere();
            ViewBag.IdTizio = IdCliente;
            return View();
        }

        [Authorize(Roles = "Amministratore, Master")]
        public IActionResult BottoneSalvaPrenotazione(Prenotazioni prenotazione, string TipoPensione, int IdCliente)
        {
            prenotazione.IdClienti = IdCliente;

            // Assicurati che le date siano impostate correttamente
            if (prenotazione.DataInizio < DateTime.Now)
            {
                ModelState.AddModelError("DataInizio", "La data di inizio non può essere nel passato.");
                return View("FormPrenotazioni");
            }

            prenotazione.MezzaPensione = false;
            prenotazione.PernottamentoPrimaColazione = false;
            prenotazione.PensioneCompleta = false;

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
            PrenotazioniDao.CreaFormPreno(prenotazione);

            return RedirectToAction("Index");
        }



        //********************************************************

        [Authorize(Roles = "Master")]
        public IActionResult FormServizi()
        {

            return View();
        }

        public IActionResult BottoneSalvaServizio(Servizi servizio)
        {
            ServiziDao.CreaFormServizi(servizio);
            return RedirectToAction("Index");
        }
        

        //********************************************************

        [Authorize(Roles = "Amministratore, Master")]
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



        [Authorize(Roles = "Master, Amministratore")]
        public IActionResult PrenotazioniAll(int IdPrenotazioni)
        {
            var TuttePreno = PrenotazioniDao.CreaPreno();
            return View(TuttePreno);
        }

        [Authorize(Roles = "Master, Amministratore")]
        public IActionResult RedirectServizi(int IdPrenotazioni)
        {
            return RedirectToAction("GestioneServizi", new { IdPrenotazioni });
        }

        [Authorize(Roles = "Master, Amministratore")]
        public IActionResult GestioneServizi(int IdPrenotazioni)
        {
            ViewBag.IdPrenotazione = IdPrenotazioni;
            ViewBag.AllServizi = ServiziDao.TuttiServizi();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Master, Amministratore")]
        public IActionResult SalvaServiziPrenotazione(PrenotazioniServizi PrenServ, int IdPreno)
        {
            // Assicurati che PrenServ.IdPrenotazione venga impostato correttamente
            PrenServ.IdPrenotazione = IdPreno;  // Imposta IdPrenotazione correttamente
            ServiziDao.AddServizi(PrenServ);
            return RedirectToAction("PrenotazioniAll");
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
