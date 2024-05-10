using LoginPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPage.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Index(User user)
        {
            if(ModelState.IsValid)
            {
                if (user.Password == "123")
                    return RedirectToAction("Weclome");
                else
                {
                    ModelState.AddModelError("", "Wrong password");
                    return View(user);
                }

            }
            return View(user);
        }

        public ActionResult Weclome()
        {
            return View();
        }
    }
}