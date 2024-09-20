using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Tiri_Salvezza")]
    public class TiriSalvezzaController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public TiriSalvezzaController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //chiamata per prendere tutti i tiri salvezza
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tiri_Salvezza>>> GetPersonaggi()
        {
            return await _dbContext.Tiri_Salvezza.ToArrayAsync();
        }

        //chiamata per prendere i tiri salvezza per id del personaggio
        [HttpGet("{Id}")]
        public async Task<ActionResult<Tiri_Salvezza>> GetTiriSalvezzaoById(int Id)
        {
            var Salvezz = await _dbContext.Tiri_Salvezza.FindAsync(Id);
            if (Salvezz == null)
            {
                return NotFound();
            }
            return Salvezz;
        }

        //Chiamta per inserire un i tiri salvezza 
        [HttpPost]
        public async Task<ActionResult<Tiri_Salvezza>> PostTiriSalvezza(Tiri_Salvezza tiriSalvezza)
        {
            _dbContext.Tiri_Salvezza.Add(tiriSalvezza);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //chiamata per modificare le competenze sui tiri salvezza 
        [HttpPut]
        public async Task<ActionResult> UpdateTiriSalvezza(Tiri_Salvezza tiroSalvezza)
        {
            var Salvezz = await _dbContext.Tiri_Salvezza.SingleOrDefaultAsync(c => c.TiriSalvezzaId == tiroSalvezza.TiriSalvezzaId);
            if (Salvezz == null || tiroSalvezza == null)
            {
                return NotFound();
            }

            Salvezz.Forza = tiroSalvezza.Forza;
            Salvezz.Destrezza = tiroSalvezza.Destrezza;
            Salvezz.Costituzione = tiroSalvezza.Costituzione;
            Salvezz.Saggezza = tiroSalvezza.Saggezza;
            Salvezz.Intelligenza = tiroSalvezza.Intelligenza;
            Salvezz.Carisma = tiroSalvezza.Carisma;

            _dbContext.Tiri_Salvezza.Update(Salvezz);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //chiamata per eiminare tiro salvezza
        [HttpDelete("{tiroSalvezzaId}")]
        public async Task eliminazioneTiriSalvezzaAsync(int tiroSalvezzaId)
        {
            var Salvezz = await _dbContext.Tiri_Salvezza.SingleAsync(c => c.TiriSalvezzaId == tiroSalvezzaId);
            _dbContext.Tiri_Salvezza.Remove(Salvezz);
            await _dbContext.SaveChangesAsync();
        }
    }
}
