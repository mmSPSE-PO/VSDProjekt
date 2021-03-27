using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VSDProjekt.Data;
using VSDProjekt.Model;

namespace VSDProjekt.Pages.Zariadenia
{
    public class IndexModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(VSDProjekt.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<zariadenie> zariadenie { get;set; }

        public async Task OnGetAsync()
        {
            zariadenie = await _context.zariadenie.Where(e=>e.UserID == _userManager.GetUserId(User)).ToListAsync();
        }
    }
}
