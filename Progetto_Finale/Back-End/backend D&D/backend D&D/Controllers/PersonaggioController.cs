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
            var personaggio = await _dbContext.Personaggio.Where(p => p.IdUtente == IdUtente).Include(c => c.Classi).ToListAsync();
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

        ////Chiamta per inserire un personaggio 
        //[HttpPost]
        //public async Task<ActionResult<Personaggio>> PostPersonaggio(Personaggio personaggio)
        //{
        //    _dbContext.Personaggio.Add(personaggio);
        //    await _dbContext.SaveChangesAsync();
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> CreatePersonaggio([FromBody] Personaggio personaggio)
        {
            if (personaggio == null)
            {
                return BadRequest("Il personaggio non può essere nullo.");
            }

            // Aggiungi il personaggio al contesto
            await _dbContext.Personaggio.AddAsync(personaggio);

            // Salva le modifiche nel database
            await _dbContext.SaveChangesAsync();

            // Restituisci l'ID del personaggio creato con un 201 Created
            return CreatedAtAction(nameof(GetPersonaggioById), new { Id = personaggio.PersonaggioID }, new { PersonaggioID = personaggio.PersonaggioID });
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

        [HttpDelete("{personaggioId}")]
        public async Task<IActionResult> EliminazionePersonaggioAsync(int personaggioId)
        {
            // Trova il personaggio e le sue entità correlate
            var personaggio = await _dbContext.Personaggio
                .Include(p => p.Classi)
                .Include(p => p.Armi)
                .Include(p => p.Armatura)
                .Include(p => p.Abilita)
                .Include(p => p.Attributi)
                .Include(p => p.Tiri_Salvezza)
                .Include(p => p.Backgound)
                .Include(p => p.Inventario)
                .FirstOrDefaultAsync(p => p.PersonaggioID == personaggioId);

            if (personaggio == null)
            {
                return NotFound();
            }

            // Rimuovi le entità correlate
            if (personaggio.Classi != null && personaggio.Classi.Count > 0)
            {
                _dbContext.Classi.RemoveRange(personaggio.Classi);
            }
            if (personaggio.Armi != null && personaggio.Armi.Count > 0)
            {
                _dbContext.Armi.RemoveRange(personaggio.Armi);
            }
            if (personaggio.Armatura != null && personaggio.Armatura.Count > 0) // Assuming Armatura is a single entity
            {
                _dbContext.Armatura.RemoveRange(personaggio.Armatura);
            }
            if (personaggio.Inventario != null && personaggio.Inventario.Count > 0) // Assuming Armatura is a single entity
            {
                _dbContext.Inventario.RemoveRange(personaggio.Inventario);
            }
            if (personaggio.Abilita != null) // Assuming Abilita is a single entity
            {
                _dbContext.Abilita.Remove(personaggio.Abilita);
            }
            if (personaggio.Attributi != null) // Assuming Attributi is a single entity
            {
                _dbContext.Attributi.Remove(personaggio.Attributi);
            }
            if (personaggio.Tiri_Salvezza != null)
            {
                _dbContext.Tiri_Salvezza.Remove(personaggio.Tiri_Salvezza);
            }
            if (personaggio.Backgound != null)
            {
                _dbContext.Backgound.Remove(personaggio.Backgound);
            }

            // Rimuovi il personaggio stesso
            _dbContext.Personaggio.Remove(personaggio);

            // Salva le modifiche nel database
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
