using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.Zasuvky
{
    public class IndexModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public float[] Hodiny { get; set; }
        public IndexModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
            Hodiny = new float[24];
        }

        public IList<zasuvka> zasuvka { get;set; }

        public async Task OnGetAsync()
        {
            zasuvka = await _context.zasuvka
                .Include(z => z.Zariadenie).ToListAsync();
        }
    }
}
