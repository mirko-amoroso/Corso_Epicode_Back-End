using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Context;
using Project_M2_S3.Interfacce;
using Project_M2_S3.Models;
using Project_M2_S3.Models.Entity;
using Project_M2_S3.Service;
using System.Diagnostics;
using System.Net;

namespace Project_M2_S3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext DContext;
        private readonly IOrder ServiceOrder;

        public HomeController(ILogger<HomeController> logger, DataContext _DContext, IOrder _ServiceOrder)
        {
            _logger = logger;
            DContext = _DContext;
            ServiceOrder = _ServiceOrder;
        }

        public IActionResult Index()
        {
            return View();
        }

        //***************************************************************

        [Authorize(Roles = "Amministratore")]
        public IActionResult TuttiOrdini()
        {
            var DiTutto = ServiceOrder.GetAll();
            return View(DiTutto);
        }

        [Authorize(Roles = "Amministratore")]
        public IActionResult CambiaDone(int IdOrder)
        {
            ServiceOrder.Update(IdOrder);
            return RedirectToAction("TuttiOrdini");
        }

        //***************************************************************

        [Authorize(Roles = "Amministratore")]
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
