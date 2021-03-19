﻿using System;
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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.FirstOrDefaultAsync(m => m.EventID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
