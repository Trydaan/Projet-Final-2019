using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;

namespace AboMagAdmin.Pages.Magazines
{
    public class DeleteModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public DeleteModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Magazine Magazine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Magazine = await _context.Magazines.FirstOrDefaultAsync(m => m.Id == id);

            if (Magazine == null)
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

            Magazine = await _context.Magazines.FindAsync(id);

            if (Magazine != null)
            {
                _context.Magazines.Remove(Magazine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
