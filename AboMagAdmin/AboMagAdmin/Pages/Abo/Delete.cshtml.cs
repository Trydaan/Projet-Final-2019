using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;

namespace AboMagAdmin.Pages.Abo
{
    public class DeleteModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public DeleteModel(AboMagAdmin.Data.ApplicationDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abonnement = await _context.Abonnements.FindAsync(id);

            if (Abonnement != null)
            {
                _context.Abonnements.Remove(Abonnement);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
