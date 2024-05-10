using SimpleForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Web;
using System.Web.Mvc;

namespace SimpleForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayLoginInput(Person model)
        {
            return View("Welcome", model);
        }

    }
}