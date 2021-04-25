using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.Zasuvky
{
    public class IndexModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public float[] Hodiny { get; set; }
        public IndexModel(VSDProjekt.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            Hodiny = new float[25];
        }

        public IList<zasuvka> zasuvka { get;set; }

        public async Task OnGetAsync()
        {
            zasuvka = await _context.zasuvka
                .Where(z=>z.UserID.Equals(_userManager.GetUserId(User)))
                .Include(z => z.Zariadenie)
                .ToListAsync();
        }
    }
}
