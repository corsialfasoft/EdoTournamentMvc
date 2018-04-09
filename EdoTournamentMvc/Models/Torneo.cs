using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EdoTournamentMvc.Models {
    public class Torneo {
        [Required]
        public string Nome {get; set;}

        [Required]
        public string Descrizione {get; set;}

        [Required]
        [Range(0,1000000)]
        public double Premio {get; set;}
    }
}