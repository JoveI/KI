using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArheoloskiNaog.Models;

namespace ArheoloskiNaog.Controllers
{
    public class HomeController : Controller
    {
        //davam komentar

        ArheologijaDBContext db = new ArheologijaDBContext();

        public ActionResult Index()
        {
            return View("~/Views/Home/Pocetna.cshtml",db.Localities.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}