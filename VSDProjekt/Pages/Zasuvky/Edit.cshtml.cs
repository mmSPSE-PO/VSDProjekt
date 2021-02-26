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

namespace VSDProjekt.Pages.Zasuvky
{
    public class EditModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public EditModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public zasuvka zasuvka { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            zasuvka = await _context.zasuvka
                .Include(z => z.Zariadenie).FirstOrDefaultAsync(m => m.zasuvkaID == id);

            if (zasuvka == null)
            {
                return NotFound();
            }
           ViewData["zariadenieID"] = new SelectList(_context.zariadenie, "zariadenieID", "zariadenieID");
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

            _context.Attach(zasuvka).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!zasuvkaExists(zasuvka.zasuvkaID))
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

        private bool zasuvkaExists(int id)
        {
            return _context.zasuvka.Any(e => e.zasuvkaID == id);
        }
    }
}
