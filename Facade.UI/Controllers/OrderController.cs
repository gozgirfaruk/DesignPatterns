using Facade.UI.DAL;
using Facade.UI.FacadePatterns;
using Microsoft.AspNetCore.Mvc;

namespace Facade.UI.Controllers
{
    public class OrderController : Controller
    {
        FacadeContext _context=new FacadeContext();
        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerid, int productid,int orderid,int productcount,decimal productprice )
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerid, productid, orderid, productprice);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
   
    }
}
