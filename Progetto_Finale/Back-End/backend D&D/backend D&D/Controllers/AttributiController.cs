using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Attributi")]
    public class AttributiController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public AttributiController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per prendere tutti gli attributi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attributi>>> GetAttributi()
        {
            return await _dbContext.Attributi.ToArrayAsync();
        }

        //chiamta per predere una Armatura per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Attributi>> GertAttributiById(int Id)
        {
            var attributi = await _dbContext.Attributi.FindAsync(Id);
            if (attributi == null)
            {
                return NotFound();
            }
            return attributi;
        }

        //Chiamta per inserire un personaggio 
        [HttpPost]
        public async Task<ActionResult<Attributi>> PostAttributi(Attributi attributi)
        {
            _dbContext.Attributi.Add(attributi);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chimata per modificare le armature
        [HttpPut]
        public async Task<ActionResult> UpdateAttributi(Attributi attributi)
        {
            var stats = await _dbContext.Attributi.SingleOrDefaultAsync(c => c.AttributiId == attributi.AttributiId);
            if (stats == null)
            {
                return NotFound();
            }

            stats.Forza = attributi.Forza;
            stats.Destrezza = attributi.Destrezza;
            stats.Costituzione = attributi.Costituzione;
            stats.Saggezza = attributi.Saggezza;
            stats.Intelligenza = attributi.Intelligenza;
            stats.Carisma = attributi.Carisma;
            stats.PV = attributi.PV;
            
            Console.WriteLine(stats.PV);

            _dbContext.Attributi.Update(stats);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chiamata per eliminare un Attributo
        [HttpDelete("{attributiId}")]
        public async Task eliminazioneAttributiAsync(int attributiId)
        {
            var stats = await _dbContext.Attributi.SingleAsync(c => c.AttributiId == attributiId);
            _dbContext.Attributi.Remove(stats);
            await _dbContext.SaveChangesAsync();
        }
    }
}
