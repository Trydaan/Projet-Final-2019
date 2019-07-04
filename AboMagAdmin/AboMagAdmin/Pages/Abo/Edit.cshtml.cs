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

namespace AboMagAdmin.Pages.Abo
{
    public class EditModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public EditModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Abonnement Abonnement { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abonnement = await _context.Abonnements
                .Include(a => a.Magazine)
                .Include(a => a.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Abonnement == null)
            {
                return NotFound();
            }
           ViewData["MagazineId"] = new SelectList(_context.Magazines, "Id", "Id");
           ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Abonnement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbonnementExists(Abonnement.Id))
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

        private bool AbonnementExists(int id)
        {
            return _context.Abonnements.Any(e => e.Id == id);
        }
    }
}
