using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iceParodi.Models;
namespace iceParodi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {             
            return View();
        }
        [HttpPost]
        public ActionResult MessageAdmin(User usuario)
        {

            if (!ModelState.IsValid){

                return View("Login");

            }else{
                Mensaje msj = new Mensaje();
                if (msj.Reuniones == null) {

                    msj.Reuniones = new SelectList(new List<SelectListItem>() {
                        new SelectListItem(){Text = "Elegir Reunion", Value = "null"},
                        new SelectListItem(){Text = "Predicacion", Value = "1"},
                        new SelectListItem(){Text = "Ensenianza", Value = "2"},
                        new SelectListItem(){Text = "Jovenes", Value = "3"},
                        new SelectListItem(){Text = "Femenina", Value = "4"},
                        new SelectListItem(){Text = "Retiro", Value = "5"},
                        new SelectListItem(){Text = "Matrimonios", Value = "6"},
                        new SelectListItem(){Text = "Adolescentes", Value = "7"}

                    },"Value","Text");
                }

                return View(msj);

            }
            
        }

        [HttpPost] //queda comentado por ahora
        public ActionResult MessageAdmin(Mensaje msj)
        {
            if (ModelState.IsValid)
            {
                ViewBag.messaje = "Mensaje guardado";
                return View();
            }
            return View();
        }
        [HttpGet]
        public ActionResult MessageAdmin()
        {

            return RedirectToAction("Login");

        }
    }
}