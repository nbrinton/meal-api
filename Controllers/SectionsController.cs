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
    [Route("api/sections")]
    [ApiController]
    [Authorize]
    public class SectionsController : ControllerBase
    {
        private readonly MealDbContext _context;

        public SectionsController(MealDbContext context)
        {
            _context = context;
        }

        // GET: api/sections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Section>>> GetSections()
        {
            return await _context.Sections.ToListAsync();
        }

        // GET: api/sections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Section>> GetSection(long id)
        {
            var section = await _context.Sections.FindAsync(id);

            if (section == null)
            {
                return NotFound();
            }

            return section;
        }

        // PUT: api/sections/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSection(long id, Section section)
        {
            if (id != section.Id)
            {
                return BadRequest();
            }

            _context.Entry(section).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionExists(id))
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

        // POST: api/sections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Section>> PostSection(Section section)
        {
            _context.Sections.Add(section);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSection), new { id = section.Id }, section);
        }

        // DELETE: api/sections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSection(long id)
        {
            var section = await _context.Sections.FindAsync(id);
            if (section == null)
            {
                return NotFound();
            }

            _context.Sections.Remove(section);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SectionExists(long id)
        {
            return _context.Sections.Any(e => e.Id == id);
        }
    }
}
