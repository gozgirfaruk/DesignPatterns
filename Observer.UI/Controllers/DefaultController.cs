using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Observer.UI.DAL;
using Observer.UI.Models;
using Observer.UI.ObserverPattern;

namespace Observer.UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;
        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appuser = new AppUser
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Mail,
                UserName = model.UserName,
                City = model.City,
                District = model.District
            };

            var result = await _userManager.CreateAsync(appuser, model.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appuser);
                return View();
            }
            return View();


        }
    }
}
