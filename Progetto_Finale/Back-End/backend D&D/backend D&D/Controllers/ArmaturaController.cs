using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Armatura")]
    public class ArmaturaController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public ArmaturaController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per prendere tutte le armature
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armatura>>> GetArmatura()
        {
            return await _dbContext.Armatura.ToArrayAsync();
        }

        //chiamta per predere una Armatura per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Armatura>> GertArmaturaById(int Id)
        {
            var armatura = await _dbContext.Armatura.FindAsync(Id);
            if (armatura == null)
            {
                return NotFound();
            }
            return armatura;
        }

        //Chiamta per inserire una Armatura 
        [HttpPost]
        public async Task<ActionResult<Armatura>> PostArmatura(Armatura armatura)
        {
            _dbContext.Armatura.Add(armatura);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chimata per modificare le armature
        [HttpPut]
        public async Task<ActionResult> UpdateArmatura(Armatura armatura)
        {
            var equip = await _dbContext.Armatura.SingleOrDefaultAsync(c => c.ArmaturaId == armatura.ArmaturaId);
            if (equip == null)
            {
                return NotFound();
            }

            equip.Nome = armatura.Nome;
            equip.CA = armatura.CA;
            equip.Effetto = armatura.Effetto;
            equip.Indossato = armatura.Indossato;
            
            _dbContext.Armatura.Update(equip);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chiamata per eliminare una armatura
        [HttpDelete("{armaturaId}")]
        public async Task eliminazioneArmaturaAsync(int armaturaId)
        {
            var equip = await _dbContext.Armatura.SingleAsync(c => c.ArmaturaId == armaturaId);
            _dbContext.Armatura.Remove(equip);
            await _dbContext.SaveChangesAsync();
        }
    }
}
