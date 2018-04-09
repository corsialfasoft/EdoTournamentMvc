using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EdoTournamentMvc.Models;

namespace EdoTournamentMvc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GestoreTornei() {
            ViewBag.Message = "Pagina per la Gestione dei tuoi Tornei!";
            return View();
        }
    }
}