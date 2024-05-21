using Microsoft.AspNetCore.Mvc;

namespace DigitalLibraryApplication.Controllers
{
    public class Welcome : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to digital library";
            return View();
        }
        public string Description()
        {
            return "This is the application for managing digital books";
        }
    }
}
