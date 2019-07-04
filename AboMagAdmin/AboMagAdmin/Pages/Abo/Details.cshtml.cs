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
    public class DetailsModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public DetailsModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Abonnement Abonnement { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abonnement = await _context.Abonnements
                .Include(a => a.Magazine)
                .Include(a => a.User)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (Abonnement == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
