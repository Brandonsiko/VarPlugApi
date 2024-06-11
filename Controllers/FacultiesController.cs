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
    public class FacultiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FacultiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Faculties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faculty>>> GetFaculty()
        {
          if (_context.Faculty == null)
          {
              return NotFound();
          }
            return await _context.Faculty.ToListAsync();
        }

        // GET: api/Faculties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faculty>> GetFaculty(int id)
        {
          if (_context.Faculty == null)
          {
              return NotFound();
          }
            var faculty = await _context.Faculty.FindAsync(id);

            if (faculty == null)
            {
                return NotFound();
            }

            return faculty;
        }

        // GET: api/Faculties/5
        [HttpGet("byname/{name}")]
        public async Task<ActionResult<IEnumerable<Faculty>>> GetFacultyByName(string name)
        {
            

            if (_context.Faculty == null)
            {
                return NotFound();
            }
            var University = new University();

            var faculty = _context.Faculty
            .Where(d => d.Name.Contains(name))
             .Select(faculty => new dbaUniversity
             {
                 FacultyId = faculty.Id,
                 FacultyName = faculty.Name,
                 UniversityName = _context.universities
                     .Where(u => u.UNI_Id == faculty.UniversityId)
                     .Select(u => u.UNI_Name)
                     .FirstOrDefault()
             })
             .ToList();

            if (faculty == null)
            {
                return NotFound();
            }
            return Ok(faculty);

            //return  Ok(await _context.Faculty.Where(d=>d.Name.Contains(name)).ToListAsync());
        }

        // PUT: api/Faculties/5,
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaculty(int id, Faculty faculty)
        {
            if (id != faculty.Id)
            {
                return BadRequest();
            }

            _context.Entry(faculty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultyExists(id))
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

        // POST: api/Faculties
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Faculty>> PostFaculty(Faculty faculty)
        {
          if (_context.Faculty == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Faculty'  is null.");
          }
            _context.Faculty.Add(faculty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaculty", new { id = faculty.Id }, faculty);
        }

        // DELETE: api/Faculties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaculty(int id)
        {
            if (_context.Faculty == null)
            {
                return NotFound();
            }
            var faculty = await _context.Faculty.FindAsync(id);
            if (faculty == null)
            {
                return NotFound();
            }

            _context.Faculty.Remove(faculty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacultyExists(int id)
        {
            return (_context.Faculty?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
