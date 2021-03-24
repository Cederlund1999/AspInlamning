using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspInlamning.Data;
using AspInlamning.Models;

namespace AspInlamning.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly AspInlamning.Data.AspInlamningContext _context;

        public DetailsModel(AspInlamning.Data.AspInlamningContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public bool JoinedEvent { get; set; } = false;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.Include(og => og.Organizer).Where(ev => ev.EventID == id).FirstOrDefaultAsync();
            Register register = await _context.Register.Where(at => at.Attendee.AttendeeID == 1 && at.Event.EventID == id).FirstOrDefaultAsync();
            
            if (register != default)
            {
                JoinedEvent = true;
            }
            if (Event == null)
            {
                return NotFound();
            }
            return Page();


            

            /*Event = await _context.Events.FirstOrDefaultAsync(m => m.EventID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();*/
        }
    }
}
