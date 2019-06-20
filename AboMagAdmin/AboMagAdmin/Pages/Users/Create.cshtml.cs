using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AboMagAdmin.Data;
using AboMagAdmin.Models;
using static AboMagAdmin.Areas.Identity.Pages.Account.RegisterModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AboMagAdmin.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public CreateModel(AboMagAdmin.Data.ApplicationDbContext context, 
            UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [BindProperty]
        [Display(Name = "Confirmation par email")]
        public bool VerifyEmail { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userToCreate = new User {
                UserName = User.Email,
                Email = User.Email,
                Nom = User.Nom,
                Prenom = User.Prenom,
                DateNaissance = User.DateNaissance,
                LieuNaissance = User.LieuNaissance,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(userToCreate, Password);

            if (result.Succeeded)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            //var emptyUser = new User { UserName = User.Email, EmailConfirmed = true  };

            //if (await TryUpdateModelAsync<User>(
            //    emptyUser, 
            //    "user",

            //    u => u.Nom, 
            //    u => u.Prenom,
            //    u => u.Email, 
            //    u => u.DateNaissance, 
            //    u => u.LieuNaissance,
            //    u => u.EmailConfirmed))
            //{

            //    //_context.Users.Add(User);                
            //    //await _context.SaveChangesAsync();
            //    var result = await _userManager.CreateAsync(User, Password);
            //    return RedirectToPage("./Index");
            //}

            return null;            
        }
    }
}