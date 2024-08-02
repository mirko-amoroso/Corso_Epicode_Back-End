using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Context;
using Project_M2_S3.Models;
using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Controllers
{
    public class AccountController : Controller
    {

        private readonly DataContext DContext;

        public AccountController(DataContext _DContext)
        {
            DContext = _DContext;
        }

        public IActionResult RedirectLogin()
        {
            return RedirectToAction("Login");
        }


        public IActionResult Login([FromQuery] string? returnUrl = "/")
        {
            TempData["ReturnUrl"] = returnUrl;
            return View();
        }
        //************************************************

        public IActionResult Register() 
        {
            return View();
        }

        public IActionResult RedirectRegister()
        {
            return RedirectToAction("Register");
        }

        //************************************************

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User model) 
        {
            if (ModelState.IsValid) 
            {
                DContext.Add(model);
                DContext.SaveChanges();
                UserRole userRole = new UserRole();
                userRole.UserId = model.Id;
                userRole.RoleId = 2;
                DContext.UsersRoles.Add(userRole);
                DContext.SaveChanges();
                return RedirectToAction("");
            }
            return RedirectToAction("Register");
        }

        //************************************************

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                // Trova l'utente nel database e include i ruoli
                var user = await DContext.Users
                    .Include(u => u.UsersRoles)
                    .ThenInclude(ur => ur.Role)
                    .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);

                if (user == null)
                {
                    // Mostra errore se l'utente non è trovato
                    ModelState.AddModelError(string.Empty, "Credenziali non valide.");
                    return View(model);
                }

                // Ottieni i ruoli dell'utente
                var roles = user.UsersRoles.Select(ur => ur.Role.Name).ToList();

                // Crea i claims
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) // Aggiungi l'ID utente qui
        };

                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                    Console.WriteLine(role);
                }

                // Crea il principal
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true, // Se vuoi che il login persista dopo la chiusura del browser
                    RedirectUri = returnUrl
                };

                // Fai login
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return LocalRedirect(returnUrl);
            }

            // Se qualcosa va storto, rimanda alla vista di login
            return View(model);
        }

        //************************************************
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
