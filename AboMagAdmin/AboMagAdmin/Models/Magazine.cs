using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AboMagAdmin.Models
{
    public class Magazine
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        [Display(Name = "Nombre de numéro à l'année")]
        public int Nb { get; set; }

        //TODO : Photo

        public string Description { get; set; }

        [Display(Name = "Prix de l'abonnement (annuel)")]
        public double PrixAnnuel { get; set; }

        public List<Abonnement> Abonnements { get; set; }
    }
}
