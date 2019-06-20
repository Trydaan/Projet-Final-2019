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
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;

namespace AboMagAdmin.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly AboMagAdmin.Data.ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IEmailSender _emailSender;

        public CreateModel(AboMagAdmin.Data.ApplicationDbContext context, 
            UserManager<User> userManager,
            IEmailSender emailSender)
        {
            _context = context;
            _userManager = userManager;
            _emailSender = emailSender;
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
                EmailConfirmed = !VerifyEmail                
            };

            var result = await _userManager.CreateAsync(userToCreate, Password);

            if (result.Succeeded)
            {
                if (VerifyEmail)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(userToCreate);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userToCreate.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(userToCreate.Email, "Vérification de votre email",
                        $"Pour activer votre compte, <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>cliquez ici</a>.");
                }
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