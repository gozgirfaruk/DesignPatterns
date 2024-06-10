using Microsoft.AspNetCore.Mvc;
using TemplateMethod.UI.TemplatePatterns;

namespace TemplateMethod.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlansType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(69.99);
            ViewBag.v4 = netflixPlans.Content("Film/Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480");
            return View();
        }

        public IActionResult StandartPlan()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlansType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(129.99);
            ViewBag.v4 = netflixPlans.Content("Film/Dizi/Belgesel");
            ViewBag.v5 = netflixPlans.Resolution("720");
            return View();

        }

        public IActionResult PremiumPlan()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlansType("Premium Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(205.99);
            ViewBag.v4 = netflixPlans.Content("Tüm İçerikler");
            ViewBag.v5 = netflixPlans.Resolution("4K");
            return View();
        }
    }
}
