using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AboMagAdmin.Data;
using AboMagAdmin.Models;

namespace AboMagAdmin.Pages.Abo
{
    public class CreateModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public CreateModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MagazineId"] = new SelectList(_context.Magazines, "Id", "Id");
        ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Abonnement Abonnement { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Abonnements.Add(Abonnement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}