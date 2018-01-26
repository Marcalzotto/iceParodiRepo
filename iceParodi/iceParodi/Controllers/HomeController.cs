using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iceParodi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Quienes_somos() {
            return View();
        }

        public ActionResult Quien_eres() {
            return View();
        }

        public ActionResult Jovenes()
        {
            return View();
        }

        public ActionResult Adolescentes()
        {
            return View();
        }

        public ActionResult Escuela_biblica()
        {
            return View();
        }

        public ActionResult Femenina()
        {
            return View();
        }

        public ActionResult Retiros()
        {
            return View();
        }

        public ActionResult Ensenianza()
        {
            return View();
        }

        public ActionResult Mensajes()
        {
            return View();
        }





    }
}