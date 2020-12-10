using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HiveStudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Portfolio()
        {

            return View();
        }

        public ActionResult Contato()
        {

            return View();
        }
        public ActionResult RegistraFoto()
        {

            return View();
        }
    }
}