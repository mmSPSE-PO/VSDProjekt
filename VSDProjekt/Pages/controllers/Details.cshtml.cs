using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.controllers
{
    public class DetailsModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public DetailsModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public controller controller { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            controller = await _context.controller.FirstOrDefaultAsync(m => m.controllerID == id);

            if (controller == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
