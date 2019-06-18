using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AboMagAdmin.Data;
using AboMagAdmin.Models;

namespace AboMagAdmin.Pages.Users
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
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyUser = new User();

            if (await TryUpdateModelAsync<User>(
                emptyUser, 
                "user", 
                u => u.Nom, 
                u => u.Prenom, 
                u => u.Email, 
                u => u.DateNaissance, 
                u => u.LieuNaissance))
            {
                _context.Users.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return null;            
        }
    }
}