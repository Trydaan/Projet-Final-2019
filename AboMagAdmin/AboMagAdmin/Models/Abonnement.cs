using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AboMagAdmin.Models
{
    public class Abonnement
    {
        public int Id { get; set; }

        [Display(Name ="Début")]
        [DataType(DataType.Date)]
        public DateTime Debut { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fin { get; set; }

        public int MagazineId { get; set; }
        public Magazine Magazine { get; set; }

        public int UserId { get; set; }

        [Display(Name ="Abonné")]
        public User User { get; set; }

        
    }
}
