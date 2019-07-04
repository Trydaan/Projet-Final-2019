using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboMagAdmin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AboMagAdmin.Areas.Identity.Pages.Account
{
    public class ResendEmailConfirmationModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public string Email { get; set; }

        public ResendEmailConfirmationModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        //public async Task<IActionResult> OnGetAsync()
        //{

        //}

        //public async Task<IActionResult> OnPostAsync()
        //{

        //}
    }
}