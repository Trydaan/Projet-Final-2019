using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;

namespace AboMagAdmin.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public EditModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FindAsync(id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(User).State = EntityState.Modified;
            var userToUpdate = await _context.Users.FindAsync(id);

            try
            {
                if (await TryUpdateModelAsync<User>(
                    userToUpdate, 
                    "User",
                    u => u.Nom,
                    u => u.Prenom,
                    u => u.Email,
                    u => u.DateNaissance,
                    u => u.LieuNaissance))
                {
                    await _context.SaveChangesAsync();
                }                                
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!UserExists(User.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
