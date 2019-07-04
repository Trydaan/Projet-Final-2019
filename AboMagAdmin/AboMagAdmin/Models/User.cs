using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AboMagAdmin.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser<int>
    {
        public string Nom { get; set; }

        [Display(Name ="Prénom")]
        public string Prenom { get; set; }

        public override string Email { get; set; }

        [DataType(DataType.Date), Display(Name ="Date de naissance")]
        public DateTime DateNaissance { get; set; }

        [Display(Name ="Lieu de naissance")]
        public string LieuNaissance { get; set; }

        public List<Abonnement> Abonnements { get; set; }

        [NotMapped]
        public string NomComplet
        {
            get
            {
                if ((Prenom != String.Empty) && (Nom != String.Empty))
                {
                    return Prenom + " " + Nom;
                }
                return Email;
            }            
        }        
    }
}
