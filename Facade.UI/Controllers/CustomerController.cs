using Facade.UI.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Facade.UI.Controllers
{
    public class CustomerController : Controller
    {
        
        [HttpGet]
        public IActionResult AddNewCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            using var _context = new FacadeContext();
            _context.Customers.Add(customer);   
            _context.SaveChanges();
            return RedirectToAction("CustomerList");
        }

        public IActionResult CustomerList()
        {
            using var _context = new FacadeContext();
            var values = _context.Customers.ToList();
            return View(values);
        }


    }
}
