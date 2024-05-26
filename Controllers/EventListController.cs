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
    public class EventListController : ControllerBase
    {
        private readonly EventContext _context;

        public EventListController(EventContext context)
        {
            _context = context;
        }

        // GET: api/EventList
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEventList()
        {
            return await _context.EventList.ToListAsync();
        }

        // GET: api/EventList/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(long id)
        {
            var @event = await _context.EventList.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            return @event;
        }

        // PUT: api/EventList/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(long id, Event @event)
        {
            if (id != @event.Id)
            {
                return BadRequest();
            }

            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
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

        // POST: api/EventList
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event @event)
        {
            _context.EventList.Add(@event);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetEvent", new { id = @event.Id }, @event);
            return CreatedAtAction(nameof(PostEvent), new { id = @event.Id }, @event);
        }

        // DELETE: api/EventList/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(long id)
        {
            var @event = await _context.EventList.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.EventList.Remove(@event);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventExists(long id)
        {
            return _context.EventList.Any(e => e.Id == id);
        }
    }
}
