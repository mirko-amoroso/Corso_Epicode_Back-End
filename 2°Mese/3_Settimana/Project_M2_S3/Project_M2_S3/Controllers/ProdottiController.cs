using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Context;
using Project_M2_S3.Interfacce;
using Project_M2_S3.Models;
using Project_M2_S3.Models.Entity;
using Project_M2_S3.Service;

namespace Project_M2_S3.Controllers
{
    public class ProdottiController : Controller
    {
        private readonly DataContext DContext;
        private readonly IPizze ServicePizze;
        private readonly IIngredienti ServiceIngredienti;
        private readonly IOrder ServiceOrder;

        public ProdottiController(
            DataContext context,
            IPizze _ServicePizze,
            IIngredienti _ServiceIngredienti,
            IOrder _ServiceOrder
        )
        {
            DContext = context;
            ServicePizze = _ServicePizze;
            ServiceIngredienti = _ServiceIngredienti;
            ServiceOrder = _ServiceOrder;
        }

        //Il form
        [Authorize(Roles = "Amministratore")]
        public async Task<IActionResult> Create()
        {
            var tuttiIngredienti = await ServiceIngredienti.GetAll(); // Usa 'await' per aspettare il completamento del Task
            ViewBag.Ingredients = tuttiIngredienti;
            return View();
        }

        // la funzione di richiamo per scrivere i form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdConListInt model)
        {
            Console.WriteLine(model.ingredient.Count);
            if (!ModelState.IsValid)
            {
                // Ciclare attraverso ModelState e stampare gli errori
                foreach (var modelState in ModelState)
                {
                    var key = modelState.Key;
                    var errors = modelState.Value.Errors;

                    if (errors.Count > 0)
                    {
                        foreach (var error in errors)
                        {
                            Console.WriteLine($"Error for {key}: {error.ErrorMessage}");
                        }
                    }
                }
            }

            if (ModelState.IsValid)
            {
                await DContext.Products.AddAsync(model);
                await DContext.SaveChangesAsync();

                int productId = model.Id;

                foreach (var i in model.ingredient)
                {
                    IngredienteProd b = new IngredienteProd
                    {
                        IngredientsId = i,
                        ProductsId = productId
                    };
                    DContext.IngredientProduct.Add(b);
                    DContext.SaveChanges();
                }

                await DContext.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
        //*************************************************************

        [Authorize(Roles = "Utente, Amministratore")]
        public async Task<IActionResult> TuttePizze()
        {
            var pizze = ServicePizze.GetAll();
            return View(pizze);
        }

        public IActionResult InfoPizze(List<ProductConListIngr> ListaPizza)
        {
            ListProductEccAddress ProdottoFinale = new ListProductEccAddress
            {
                listaClasse = ListaPizza.Where(p => p.quantita > 0).ToList()
            };
            return View(ProdottoFinale);
        }

        [Authorize(Roles = "Amministratore, Utente")]
        public ActionResult InviaOrdine(ListProductEccAddress ListaPizza)
        {
            if (User.Identity.IsAuthenticated)
            {
                // Assicurati che questo non sia null
                string userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Verifica che userIdString non sia null prima di convertirlo
                if (string.IsNullOrEmpty(userIdString))
                {
                    // Gestisci l'errore, ad esempio, reindirizza o mostra un messaggio
                    return RedirectToAction("Error", "Home"); // Esempio di gestione dell'errore
                }

                int IdU = int.Parse(userIdString);
                ServiceOrder.Save(ListaPizza, IdU);
            }
            return RedirectToAction("Index", "Home");
        }


        //*************************************************************
        [Authorize(Roles = "Utente")]
        public async Task<IActionResult> Index()
        {
            var prodotti = await DContext.Products.ToListAsync();
            return View(prodotti);
        }
    }
}
