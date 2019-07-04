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
    public class IndexModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public IndexModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Abonnement> Abonnement { get;set; }

        public async Task OnGetAsync()
        {
            Abonnement = await _context.Abonnements
                .Include(a => a.Magazine)
                .Include(a => a.User).ToListAsync();
        }
    }
}
