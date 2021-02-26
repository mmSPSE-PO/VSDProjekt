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
    public class DetailsModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public DetailsModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
