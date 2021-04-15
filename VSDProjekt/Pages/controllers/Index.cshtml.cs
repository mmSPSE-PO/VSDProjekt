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
    public class IndexModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;

        public IndexModel(VSDProjekt.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<controller> controller { get;set; }

        public async Task OnGetAsync()
        {
            controller = await _context.controller.Include(e => e.Children).ToListAsync();
        }
    }
}
