using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspInlamning.Data;
using AspInlamning.Models;
using Microsoft.EntityFrameworkCore;

namespace AspInlamning.Pages.RegisterEvent
{
    public class CreateModel : PageModel
    {
        private readonly AspInlamning.Data.AspInlamningContext _context;

        public CreateModel(AspInlamning.Data.AspInlamningContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Register eventJoined = new Register()
            {
                Attendee = await _context.Attendees.Where(a => a.AttendeeID == 1).FirstOrDefaultAsync(),
                Event = await _context.Events.Where(e => e.EventID == id).FirstOrDefaultAsync()
            };
            _context.Register.Add(eventJoined);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Events/JoinEvent", new {id});
        }
        [BindProperty]
        public Register Register { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Register.Add(Register);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
