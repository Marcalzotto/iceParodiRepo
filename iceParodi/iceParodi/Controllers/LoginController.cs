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
            var usuario = new User();

            return View();
        }
        [HttpPost]
        public ActionResult Login(User usuario)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("MessageAdmin");
        }

        public ActionResult MessageAdmin()
        {
            return View();
        }
    }
}