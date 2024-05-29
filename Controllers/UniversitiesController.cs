using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VarPlugApi.Data;
using VarPlugApi.Model;

namespace VarPlugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UniversitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Universities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<University>>> Getuniversities()
        {
          if (_context.universities == null)
          {
              return NotFound();
          }
            return await _context.universities.ToListAsync();
        }

        // GET: api/Universities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<University>> GetUniversity(int id)
        {
          if (_context.universities == null)
          {
              return NotFound();
          }
            var university = await _context.universities.FindAsync(id);

            if (university == null)
            {
                return NotFound();
            }

            return university;
        }

        // PUT: api/Universities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniversity(int id, University university)
        {
            if (id != university.UNI_Id)
            {
                return BadRequest();
            }

            _context.Entry(university).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversityExists(id))
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

        // POST: api/Universities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<University>> PostUniversity(University university)
        {
          if (_context.universities == null)
          {
              return Problem("Entity set 'ApplicationDbContext.universities'  is null.");
          }
            _context.universities.Add(university);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUniversity", new { id = university.UNI_Id }, university);
        }

        // DELETE: api/Universities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUniversity(int id)
        {
            if (_context.universities == null)
            {
                return NotFound();
            }
            var university = await _context.universities.FindAsync(id);
            if (university == null)
            {
                return NotFound();
            }

            _context.universities.Remove(university);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UniversityExists(int id)
        {
            return (_context.universities?.Any(e => e.UNI_Id == id)).GetValueOrDefault();
        }
    }
}
