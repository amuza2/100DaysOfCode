using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Customers")]
        public ActionResult Customer()
        {
            var customers = Getcustomers();
            var viewModel = new CustomerViewModel()
            {
                Customers = customers
            };
            return View(viewModel);
        }
        [Route("Customers/Details")]
        public ActionResult Details(int id)
        {
            return View();
        }

        private List<Customers> Getcustomers()
        {
            var customers = new List<Customers>()
            {
                new Customers() {Name="customer 1", Id=1},
                new Customers() {Name="customer 2", Id=2}
            };
            return customers;
        }
    }
}