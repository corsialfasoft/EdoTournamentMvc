using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdoTournamentMvc.Models {
    public interface ITournament {
        string CreaTorneo(Torneo torneo);
    }

    public class DomainModel : ITournament {
        public string CreaTorneo(Torneo torneo) {
            throw new NotImplementedException();
        }
    }
}