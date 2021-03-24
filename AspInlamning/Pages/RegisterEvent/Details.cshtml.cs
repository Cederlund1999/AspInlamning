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
    public class DetailsModel : PageModel
    {
        private readonly AspInlamning.Data.AspInlamningContext _context;

        public DetailsModel(AspInlamning.Data.AspInlamningContext context)
        {
            _context = context;
        }

        public Register Register { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Register = await _context.Register.FirstOrDefaultAsync(m => m.RegisterID == id);

            if (Register == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
