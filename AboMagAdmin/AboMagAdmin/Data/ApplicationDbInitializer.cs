using AboMagAdmin.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboMagAdmin.Data
{
    public class ApplicationDbInitializer
    {
        //Initialise la base avec un compte admin
        public static void SeedUsers(UserManager<User> userManager)
        {
            if (userManager.FindByEmailAsync("admin@abomag.com").Result == null)
            {
                User user = new User
                {
                    Nom = "Lequeu",
                    Prenom = "Baptiste",
                    Email = "admin@abomag.com",
                    DateNaissance = DateTime.Parse("28/01/1995")
                };

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                //TODO: Roles pas encore implémenté
                //if (result.Succeeded)
                //{
                //    userManager.AddToRoleAsync(user, "Admin").Wait();
                //}
            }
        }
    }
}
