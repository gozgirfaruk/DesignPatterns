using ChainOfResponsibility.ChainOfResp;
using ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Payment(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee menagerAssistant = new MenagerAssistant();
            Employee menager = new Menager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(menagerAssistant);
            menagerAssistant.SetNextApprover(menager);
            menager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
