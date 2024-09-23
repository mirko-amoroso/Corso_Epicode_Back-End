using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Abilita")]
    public class AbilitaController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public AbilitaController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per predere tutte le abilità 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Abilita>>> GetAbilita()
        {
            return await _dbContext.Abilita.ToArrayAsync();
        }

        //chiamta per predere una abilità per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Abilita>> GertUtenteById(int Id)
        {
            var abilita = await _dbContext.Abilita.FindAsync(Id);
            if (abilita == null)
            {
                return NotFound();
            }
            return abilita;
        }

        [HttpPost]
        public async Task<ActionResult<Abilita>> PostAbilita(Abilita abilita)
        {
            // Verifica se esiste già un'abilità per questo PersonaggioID
            var existingAbilita = await _dbContext.Abilita
                .FirstOrDefaultAsync(a => a.PersonaggioID == abilita.PersonaggioID);

            if (existingAbilita != null)
            {
                // Se esiste già, aggiorna i campi dell'abilità esistente
                existingAbilita.Acrobazia = abilita.Acrobazia;
                existingAbilita.Addestrare_Animali = abilita.Addestrare_Animali;
                // Aggiorna anche gli altri campi...

                _dbContext.Abilita.Update(existingAbilita);
            }
            else
            {
                // Se non esiste, aggiungi una nuova abilità
                _dbContext.Abilita.Add(abilita);
            }

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Log dettagli aggiuntivi per la diagnosi
                Console.WriteLine($"Errore nel salvataggio delle abilità: {ex.InnerException?.Message}");
                return BadRequest("Si è verificato un errore durante il salvataggio.");
            }

            return Ok(abilita); // Restituisce l'oggetto abilità creato o aggiornato
        }

        //chiamata per modificare le Abilità 
        [HttpPut]
        public async Task<ActionResult> UpdateAbilita(Abilita abilita)
        {
            var ability = await _dbContext.Abilita.SingleOrDefaultAsync(c => c.AbilitaId == abilita.AbilitaId);
            if (ability == null)
            {
                return NotFound();
            }
            ability.Acrobazia = abilita.Acrobazia;
            ability.Addestrare_Animali = abilita.Addestrare_Animali;
            ability.Arcano = abilita.Arcano;
            ability.Acrobazia = abilita.Acrobazia;
            ability.Atletica = abilita.Atletica;
            ability.Furtivita = abilita.Furtivita;
            ability.Indagare = abilita.Indagare;
            ability.Inganno = abilita.Inganno;
            ability.Intimidire = abilita.Intimidire;
            ability.Intrattenere = abilita.Intrattenere;
            ability.Intuizione = abilita.Intuizione;
            ability.Medicina = abilita.Medicina;
            ability.Natura = abilita.Natura;
            ability.Percezione = abilita.Percezione;
            ability.Persuasione = abilita.Persuasione;
            ability.Rapidita_di_Mano = abilita.Rapidita_di_Mano;
            ability.Religione = abilita.Religione;
            ability.Sopravvivenza = abilita.Sopravvivenza;
            ability.Storia = abilita.Storia;

            _dbContext.Abilita.Update(ability);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
