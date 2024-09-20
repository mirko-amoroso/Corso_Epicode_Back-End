using backend_D_D.Data;
using backend_D_D.Models;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Utente")]
    public class UtentiController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public UtentiController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utente>>> GetUtente()
        {
            return await _dbContext.Utente.ToArrayAsync();
        }
        
        [HttpGet("{Id}")]
        public async Task<ActionResult<Utente>> GertUtenteById(int Id)
        {
            var utente = await _dbContext.Utente.FindAsync(Id);
            if (utente == null)
            {
                return NotFound();
            }
            return utente;

        }

        [HttpPost("Register")]
        public async Task<ActionResult<Utente>> PostUtente(Utente utente)
        {
            Console.WriteLine(utente.NomeUtente, "entra qui dentro");
            _dbContext.Utente.Add(utente);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<ActionResult<Utente>> LoginUtente(Credenziale credenziale)
        {
            var utente = await _dbContext.Utente.SingleOrDefaultAsync (u => u.Email == credenziale.Email && u.Password == credenziale.Password);
            Console.WriteLine("entra qui dentro login");
            if (utente == null) 
            {
                return NotFound();
            }
            return utente;

        }
    }
}
