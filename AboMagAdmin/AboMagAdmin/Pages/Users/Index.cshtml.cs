﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AboMagAdmin.Data;
using AboMagAdmin.Models;
using Microsoft.AspNetCore.Authorization;

namespace AboMagAdmin.Pages.Users
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;

        public IndexModel(AboMagAdmin.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
