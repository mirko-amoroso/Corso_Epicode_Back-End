using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{ 
    [ApiController]
    [Route("Inventario")]
    public class InventarioController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public InventarioController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per prendere tutto l'inventario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventario>>> GetInventario()
        {
            return await _dbContext.Inventario.ToArrayAsync();
        }

        //chiamta per predere un inventario per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Inventario>> GertInventarioById(int Id)
        {
            var inventario = await _dbContext.Inventario.FindAsync(Id);
            if (inventario == null)
            {
                return NotFound();
            }
            return inventario;
        }

        //Chiamta per inserire oggetto nell'inventario 
        [HttpPost]
        public async Task<ActionResult<Inventario>> PostPersonaggio(Inventario inventario)
        {
            _dbContext.Inventario.Add(inventario);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chimata per modificare le armature
        [HttpPut]
        public async Task<ActionResult> UpdateInventario(Inventario inventario)
        {
            var stor = await _dbContext.Inventario.SingleOrDefaultAsync(c => c.InventarioId == inventario.InventarioId);
            if (stor == null)
            {
                return NotFound();
            }

            stor.Nome = inventario.Nome;
            stor.Effetto = inventario.Effetto;

            _dbContext.Inventario.Update(stor);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //chiamata per eiminare un ogeto dll'inventario
        [HttpDelete("{inventarioId}")]
        public async Task eliminazioneInventarioAsync(int inventarioId)
        {
            var Object = await _dbContext.Inventario.SingleAsync(c => c.InventarioId == inventarioId);
            _dbContext.Inventario.Remove(Object);
            await _dbContext.SaveChangesAsync();
        }
    }
}
