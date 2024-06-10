using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Business.Abstract;
using UnitOfWork.Entity.Concrete;
using UnitOfWork.UI.Models;

namespace UnitOfWork.UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Fast()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fast(CustomerViewModel model)
        {
            var value1 = _customerService.TGetById(model.SenderID);
            var value2= _customerService.TGetById(model.ReceiverID);

            value1.Balance -= model.Amount;
            value2.Balance += model.Amount;

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,
                value2
            };
            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}
