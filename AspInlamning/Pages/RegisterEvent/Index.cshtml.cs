using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspInlamning.Data;
using AspInlamning.Models;

namespace AspInlamning.Pages.RegisterEvent
{
    public class IndexModel : PageModel
    {
        private readonly AspInlamning.Data.AspInlamningContext _context;

        public IndexModel(AspInlamning.Data.AspInlamningContext context)
        {
            _context = context;
        }

        public IList<Register> Register { get;set; }

        public async Task OnGetAsync()
        {
            Register = await _context.Register.Include(ev=>ev.Event).Where(at=>at.Attendee.AttendeeID ==1).ToListAsync();
        }
    }
}
