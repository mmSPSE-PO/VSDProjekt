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
    public class DeleteModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public DeleteModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            connected = await _context.connected.FindAsync(id);

            if (connected != null)
            {
                _context.connected.Remove(connected);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
