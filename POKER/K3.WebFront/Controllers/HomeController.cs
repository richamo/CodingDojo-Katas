using System;
using System.Collections.Generic;
using System.Web.Mvc;
using PokerHandsKata.Model;

namespace K3.WebFront.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var d = new Deck(DateTime.UtcNow.Millisecond);
            
            var h = d.GetHandsFor(5);

            var vm = new IndexViewModel { Hands = h, Deck = d};

            return View("Index", vm);
        }
    }

    public class IndexViewModel
    {
         public List<Hand> Hands { get; set; }

         public Deck Deck { get; set; }
    }
}
