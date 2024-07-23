using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Progetto_S2_M2.Controllers
{
    public class NegateController : Controller
    {

        [AllowAnonymous]
        public IActionResult Negate()
        {
            ViewBag.title = "Accesso Negato";
            return View();
        }

        [AllowAnonymous]

        public IActionResult ReturnLogin()
        {
            return RedirectToAction("Login", "Login");
        }

        [AllowAnonymous]
        public IActionResult ReturnToHome()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
