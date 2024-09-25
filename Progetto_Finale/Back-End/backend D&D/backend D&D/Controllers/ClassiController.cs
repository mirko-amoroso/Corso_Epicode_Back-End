using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Classi")]
    public class ClassiController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public ClassiController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per prendere tutte le Classi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Classi>>> GetClassi()
        {
            return await _dbContext.Classi.ToArrayAsync();
        }

        //chiamta per predere una classe per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Classi>> GertClassiById(int Id)
        {
            var Class = await _dbContext.Classi.FindAsync(Id);
            if (Class == null)
            {
                return NotFound();
            }
            return Class;
        }

        //Chiamta per inserire un personaggio 
        [HttpPost]
        public async Task<ActionResult<Classi>> PostPersonaggio(Classi classi)
        {
            _dbContext.Classi.Add(classi);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chimata per modificare le Classsi
        [HttpPut]
        public async Task<ActionResult> UpdateClassi(Classi classe)
        {
            var classi = await _dbContext.Classi.SingleOrDefaultAsync(c => c.ClassiId == classe.ClassiId);
            if (classi == null)
            {
                return NotFound();
            }

            classi.Livello = classe.Livello;
            classi.TipoClasse = classe.TipoClasse;

            Console.WriteLine(classi.Livello);

            _dbContext.Classi.Update(classi);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chiamata per eliminare una armatura
        [HttpDelete("{ClasseId}")]
        public async Task EliminazioneClassiAsync(int ClasseId)
        {
            var classe = await _dbContext.Classi.SingleAsync(c => c.ClassiId == ClasseId);
            _dbContext.Classi.Remove(classe);
            await _dbContext.SaveChangesAsync();
        }
    }
}
