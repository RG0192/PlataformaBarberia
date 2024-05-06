using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlataformaBarberia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MiPagina()
        {

            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "En este apartado mostraremos informacion acerca de la pagina.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Login()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}