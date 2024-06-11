using Facade.UI.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Facade.UI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product Product)
        {
            using var _context = new FacadeContext();
            _context.Products.Add(Product);
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            using var _context = new FacadeContext();
            var values = _context.Products.ToList();
            return View(values);
        }
    }
}
