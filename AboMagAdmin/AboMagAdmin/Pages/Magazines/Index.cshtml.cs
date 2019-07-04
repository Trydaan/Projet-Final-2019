using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;
using Microsoft.AspNetCore.Authorization;

namespace AboMagAdmin.Pages.Magazines
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public IndexModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Magazine> Magazine { get;set; }

        public async Task OnGetAsync()
        {
            Magazine = await _context.Magazines.ToListAsync();
        }
    }
}
