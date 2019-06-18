using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AboMagAdmin.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser<int>
    {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public override string Email { get; set; }

        public DateTime DateNaissance { get; set; }

        public string LieuNaissance { get; set; }
    }
}
