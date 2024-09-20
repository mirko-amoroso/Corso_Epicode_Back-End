using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Personaggio")]
    public class PersonaggioController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public PersonaggioController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //chiamata per prendere tutti i personaggi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personaggio>>> GetPersonaggi()
        {
            return await _dbContext.Personaggio.ToArrayAsync();
        }

        //chiamata per prendere un personaggio per id del personaggio
        [HttpGet("{Id}")]
        public async Task<ActionResult<Personaggio>> GetPersonaggioById(int Id)
        {
            var personaggio = await _dbContext.Personaggio.FindAsync(Id);
            if (personaggio == null)
            {
                return NotFound();
            }
            return personaggio;
        }
        
        // chimata per prendere i personaggi per id dell'utente 
        [HttpGet("Utente/{IdUtente}")]
        public async Task<ActionResult<IEnumerable<Personaggio>>> GetPersonaggiobyUtenteId(int IdUtente)
        {
            var personaggio = await _dbContext.Personaggio.Where(p=> p.IdUtente == IdUtente).Include(c => c.Classi).ToListAsync();
            Console.WriteLine(personaggio[0].Nome);
            if (personaggio == null)
            {
                return NotFound();
            }
            return personaggio;
        }
        
        [HttpGet("Completo/{personaggioID}")]
        public async Task<ActionResult<Personaggio>> GetFullPersonaggio(int personaggioID)
        {
            var personaggio = await _dbContext.Personaggio.AsSplitQuery().
                Where(p => p.PersonaggioID == personaggioID).
                Include(c => c.Classi).
                Include(a => a.Armatura).
                Include(b => b.Backgound).
                Include(ab => ab.Abilita).
                Include(ar => ar.Armi).
                Include(att => att.Attributi).
                Include(ts => ts.Tiri_Salvezza).FirstOrDefaultAsync();
            if (personaggio == null)
            {
                return NotFound();
            }
            return personaggio;
        }

        //Chiamta per inserire un personaggio 
        [HttpPost]
        public async Task<ActionResult<Personaggio>> PostPersonaggio(Personaggio personaggio)
        {
            _dbContext.Personaggio.Add(personaggio);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //chiamata per modificare un personaggio 
        [HttpPut]
        public async Task<ActionResult> UpdatePersonaggio(Personaggio personaggio)
        {
            var Charatter = await _dbContext.Personaggio.SingleOrDefaultAsync(c => c.PersonaggioID == personaggio.PersonaggioID);
            if (Charatter == null || personaggio == null)
            {
                return NotFound();
            }

            Charatter.Nome = personaggio.Nome;
            Charatter.Razza = personaggio.Razza;
            Charatter.MoneteOro = personaggio.MoneteOro;

            _dbContext.Personaggio.Update(Charatter);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //chiamata per eiminare un personaggio
        [HttpDelete("{personaggioId}")]
        public async Task eliminazionePersonaggioAsync(int personaggioId)
        {
            var Charatter = await _dbContext.Personaggio.SingleAsync(c => c.PersonaggioID == personaggioId);
            _dbContext.Personaggio.Remove(Charatter);
            await _dbContext.SaveChangesAsync();
        }
    }
}
