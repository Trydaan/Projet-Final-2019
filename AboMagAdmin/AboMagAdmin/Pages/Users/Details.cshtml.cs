using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;
using System.ComponentModel.DataAnnotations;

namespace AboMagAdmin.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public DetailsModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        [BindProperty]
        [Display(Name = "Email confirmé")]
        public string EmailState { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users
                .Include(u => u.Abonnements)
                    .ThenInclude(abo => abo.Magazine)

                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            EmailState = User.EmailConfirmed ? "Oui" : "Non";

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }

        //public async Task<IActionResult> ResendEmail(int? id)
        //{
        //    User = await _context.Users.FindAsync(id);

        //    if (User == null)
        //    {
        //        return NotFound($"Impossible de charger l'utilisateur avec l'id '{_userManager.GetUserId(User)}'.");
        //    }

        //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

        //}
    }
}
