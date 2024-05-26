using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventAuto.Models;

namespace EventAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenueListController : ControllerBase
    {
        private readonly VenueContext _context;

        public VenueListController(VenueContext context)
        {
            _context = context;
        }

        // GET: api/VenueList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venue>>> GetVenueList()
        {
            return await _context.VenueList.ToListAsync();
        }

        // GET: api/VenueList/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venue>> GetVenue(int id)
        {
            var venue = await _context.VenueList.FindAsync(id);

            if (venue == null)
            {
                return NotFound();
            }

            return venue;
        }

        // PUT: api/VenueList/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVenue(int id, Venue venue)
        {
            if (id != venue.Id)
            {
                return BadRequest();
            }

            _context.Entry(venue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VenueExists(id))
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

        // POST: api/VenueList
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Venue>> PostVenue(Venue venue)
        {
            _context.VenueList.Add(venue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenue", new { id = venue.Id }, venue);
        }

        // DELETE: api/VenueList/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenue(int id)
        {
            var venue = await _context.VenueList.FindAsync(id);
            if (venue == null)
            {
                return NotFound();
            }

            _context.VenueList.Remove(venue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VenueExists(int id)
        {
            return _context.VenueList.Any(e => e.Id == id);
        }
    }
}
