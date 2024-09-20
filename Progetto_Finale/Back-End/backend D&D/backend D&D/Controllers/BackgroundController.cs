using backend_D_D.Data;
using backend_D_D.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_D_D.Controllers
{
    [ApiController]
    [Route("Background")]
    public class BackgroundController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public BackgroundController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Chiamata per prendere tutti i background
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Background>>> GetBackground()
        {
            return await _dbContext.Backgound.ToArrayAsync();
        }

        //chiamta per predere un Background per ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Background>> GertBackGroundById(int Id)
        {
            var background = await _dbContext.Backgound.FindAsync(Id);
            if (background == null)
            {
                return NotFound();
            }
            return background;
        }

        //Chiamta per inserire un personaggio 
        [HttpPost]
        public async Task<ActionResult<Background>> PostBackground(Background background)
        {
            _dbContext.Backgound.Add(background);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        //Chimata per modificare il background
        [HttpPut]
        public async Task<ActionResult> UpdateBackground(Background background)
        {
            var back = await _dbContext.Backgound.SingleOrDefaultAsync(c => c.BackgroundId == background.BackgroundId);
            if (back == null)
            {
                return NotFound();
            }

            back.TrattiCaratteriali = back.TrattiCaratteriali;
            back.Ideali = back.Ideali;
            back.Legami = back.Legami;
            back.Difetti = back.Difetti;
            

            _dbContext.Backgound.Update(back);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
