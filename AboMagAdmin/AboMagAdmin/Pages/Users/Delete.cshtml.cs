using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;

namespace AboMagAdmin.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public DeleteModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = "Une erreur est survenue lors de la suppression, veuillez réessayer";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FindAsync(id);

            try
            {
                if (User != null)
                {
                    _context.Users.Remove(User);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException ex)
            {
                return RedirectToAction("./Delete", new { id, saveChangesError = true });
                throw;
            }
            


            return RedirectToPage("./Index");
        }
    }
}
