    using System.Security.Claims;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Soluzione_S2_M2.Interfacce;
    using Soluzione_S2_M2.Login;

    namespace Progetto_S2_M2.Controllers
    {
        public class LoginController : Controller
        {
            private readonly IAuthService _Login;

            public LoginController(IAuthService login)
            {
                _Login = login;
            }

            [AllowAnonymous]
            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Login(Soluzione_S2_M2.Login.User user)
            {
                try
                {
                    Console.WriteLine("1: Entrato nel metodo Login");
                    user.ToString();
                    Console.WriteLine("2: Dopo user.ToString()");
                    var u = _Login.Login(user.Username, user.Password);
                    Console.WriteLine("3: Dopo ServiceAuth.Login");

                    if (u == null)
                    {
                        Console.WriteLine("4: Utente non trovato, reindirizzamento a Index");
                        return RedirectToAction("Index", "Home");
                    }

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, u.Username),
                        new Claim("FrinedlyName", u.FrinedlyName ?? string.Empty)
                    };
                    Console.WriteLine("5: Claims creati");

                    u.Roles.ForEach(r =>
                    {
                        claims.Add(new Claim(ClaimTypes.Role, r));
                        Console.WriteLine($"6: Aggiunto ruolo {r}");
                    });

                    var identity = new ClaimsIdentity(
                        claims,
                        CookieAuthenticationDefaults.AuthenticationScheme
                    );
                    Console.WriteLine("7: Identity creata");

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(identity)
                    );
                    Console.WriteLine("8: Utente autenticato");
                }
                catch (Exception ex) { }
                return RedirectToAction("Index", "Home");
            }

            [AllowAnonymous]
            public async Task<IActionResult> Logout()
            {
                await HttpContext.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
        }
    }
