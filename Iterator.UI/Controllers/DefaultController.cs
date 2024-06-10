using Iterator.UI.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace Iterator.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Almanya", CityName = "Berlin",VisitPlaceName= "Berlin Duvarı" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Fransa", CityName = "Paris",VisitPlaceName= "Eyfel Kulesi" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Italya", CityName = "Venedik",VisitPlaceName= "Gondol" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Çek Cumhuriyeti", CityName = "Prag",VisitPlaceName= "Meydan" });


            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName+ ""+iterator.CurrentItem.CityName + "" + iterator.CurrentItem.VisitPlaceName);
            }
            ViewBag.v = strings;
            return View();
        }
    }
}
