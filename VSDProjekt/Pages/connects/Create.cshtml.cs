using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.connects
{
    public class CreateModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public CreateModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ParentID"] = new SelectList(_context.controller, "controllerID", "controllerID");
            return Page();
        }

        [BindProperty]
        public connected connected { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.connected.Add(connected);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
