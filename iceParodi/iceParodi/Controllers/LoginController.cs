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
        public ActionResult Login()
        {
            var usuario = new User();

            return View(usuario);
        }
        [HttpPost]
        public ActionResult Login(User usuario)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("MessageAdmin", "Login");

            }
            return View(usuario);
        }

        public ActionResult MessageAdmin()
        {
            return View();
        }
    }
}