using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.Zariadenia
{
    public class DeleteModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public DeleteModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public zariadenie zariadenie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            zariadenie = await _context.zariadenie.FirstOrDefaultAsync(m => m.zariadenieID == id);

            if (zariadenie == null)
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

            zariadenie = await _context.zariadenie.FindAsync(id);

            if (zariadenie != null)
            {
                _context.zariadenie.Remove(zariadenie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
