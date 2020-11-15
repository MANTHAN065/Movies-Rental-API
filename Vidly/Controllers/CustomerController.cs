using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;


namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private DbContext_Model _context;

        public CustomerController()
        {
            _context = new DbContext_Model();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=> c.MembershipType).ToList();
            //var customers = GetCustomers();                                        .
            return View(customers);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Mak"},
                new Customer {Id = 2, Name = "Nidhi"}
            };
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

    }
}
