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
    public class IndexModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public IndexModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<connected> connected { get;set; }

        public async Task OnGetAsync()
        {
            connected = await _context.connected
                .Include(c => c.Parent).ToListAsync();
        }
        /*
        public async Task OnPostAsync()
        {
            var a = _context.connected.FirstAsync();
            return a.
        }
        */
    }
}
