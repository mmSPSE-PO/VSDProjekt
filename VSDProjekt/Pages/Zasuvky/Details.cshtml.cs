using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.Zasuvky
{
    public class DetailsModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public DetailsModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
