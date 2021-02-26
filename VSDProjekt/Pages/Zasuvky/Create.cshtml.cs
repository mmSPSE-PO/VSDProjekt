using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VSDProjekt.Data;
using VSDProjekt.Model;
using Microsoft.AspNetCore.Identity;

namespace VSDProjekt.Pages.Zasuvky
{
    public class CreateModel : PageModel
    {
        private readonly VSDProjekt.Data.ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(VSDProjekt.Data.ApplicationDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            var b = _context.zariadenie.Where(e => e.UserID.Equals(_userManager.GetUserId(User)));
            ViewData["zariadenieID"] = new SelectList(b, "zariadenieID", "Nazov");
            return Page();
        }

        [BindProperty]
        public zasuvka zasuvka { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.zasuvka.Add(zasuvka);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
