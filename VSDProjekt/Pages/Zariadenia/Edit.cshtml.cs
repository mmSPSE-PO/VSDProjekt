using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.Zariadenia
{
    public class EditModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public EditModel(VSDProjekt.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(zariadenie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!zariadenieExists(zariadenie.zariadenieID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool zariadenieExists(int id)
        {
            return _context.zariadenie.Any(e => e.zariadenieID == id);
        }
    }
}
