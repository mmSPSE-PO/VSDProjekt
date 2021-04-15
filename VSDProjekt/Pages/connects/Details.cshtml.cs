using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.connects
{
    public class DetailsModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public DetailsModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public connected connected { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            connected = await _context.connected
                .Include(c => c.Parent).FirstOrDefaultAsync(m => m.connectedID == id);

            if (connected == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
