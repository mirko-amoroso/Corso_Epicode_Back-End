using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Armi")]
    public class ArmiController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public ArmiController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per prendere tutte le Armi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armi>>> GetArmi()
        {
            return await _dbContext.Armi.ToArrayAsync();
        }

        //chiamta per predere una Armi per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Armi>> GertArmiById(int Id)
        {
            var armi = await _dbContext.Armi.FindAsync(Id);
            if (armi == null)
            {
                return NotFound();
            }
            return armi;
        }

        //Chiamta per inserire un personaggio 
        [HttpPost]
        public async Task<ActionResult<Armi>> PostPersonaggio(Armi armi)
        {
            _dbContext.Armi.Add(armi);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chimata per modificare le armi
        [HttpPut]
        public async Task<ActionResult> UpdateArmi(Armi armi)
        {
            var equip = await _dbContext.Armi.SingleOrDefaultAsync(c => c.ArmaId == armi.ArmaId);
            if (equip == null)
            {
                return NotFound();
            }

            equip.Nome = armi.Nome;
            equip.Danno = armi.Danno;
            equip.BonusArma = armi.BonusArma;

            _dbContext.Armi.Update(equip);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chiamata per eliminare una Arma
        [HttpDelete("{armiId}")]
        public async Task eliminazioneArmiAsync(int armiId)
        {
            var equip = await _dbContext.Armi.SingleAsync(c => c.ArmaId == armiId);
            _dbContext.Armi.Remove(equip);
            await _dbContext.SaveChangesAsync();
        }
    }
}
