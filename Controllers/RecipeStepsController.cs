#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MEalAPI.DbContexts;
using MEalAPI.Entities;

namespace MEalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecipeStepsController : ControllerBase
    {
        private readonly MealDbContext _context;

        public RecipeStepsController(MealDbContext context)
        {
            _context = context;
        }

        // GET: api/RecipeSteps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ERecipeStep>>> GetRecipeSteps()
        {
            return await _context.RecipeSteps.ToListAsync();
        }

        // GET: api/RecipeSteps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ERecipeStep>> GetRecipeStep(long id)
        {
            var recipeStep = await _context.RecipeSteps.FindAsync(id);

            if (recipeStep == null)
            {
                return NotFound();
            }

            return recipeStep;
        }

        // PUT: api/RecipeSteps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipeStep(long id, ERecipeStep recipeStep)
        {
            if (id != recipeStep.Id)
            {
                return BadRequest();
            }

            _context.Entry(recipeStep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeStepExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RecipeSteps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ERecipeStep>> PostRecipeStep(ERecipeStep recipeStep)
        {
            _context.RecipeSteps.Add(recipeStep);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecipeStep), new { id = recipeStep.Id }, recipeStep);
        }

        // DELETE: api/RecipeSteps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeStep(long id)
        {
            var recipeStep = await _context.RecipeSteps.FindAsync(id);
            if (recipeStep == null)
            {
                return NotFound();
            }

            _context.RecipeSteps.Remove(recipeStep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecipeStepExists(long id)
        {
            return _context.RecipeSteps.Any(e => e.Id == id);
        }
    }
}
