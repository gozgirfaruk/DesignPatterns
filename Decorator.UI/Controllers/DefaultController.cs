using Decorator.UI.DAL;
using Decorator.UI.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.UI.Controllers
{
    public class DefaultController : Controller
    {
       
        public IActionResult Index()
        {
            iMessage message = new iMessage();
            message.Container = "Bu bir content mesajidir";
            message.Sender = "Admin";
            message.Receiver = "Herkes";
            message.Subject = "Deneme";
            CreatNewMessage createNewMessage = new CreatNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }

        public IActionResult Index2()
        { 
            iMessage message = new iMessage();
            message.Container = "Bu bir subject şifreli mesajidir";
            message.Sender = "Team Lead";
            message.Receiver = "Herkes";
            message.Subject = "Merhaba";
            CreatNewMessage createNewMessage = new CreatNewMessage();
            EncryptoBySubjectDecorator encryptoBySubjectDecorator = new EncryptoBySubjectDecorator(createNewMessage);
            encryptoBySubjectDecorator.SendMessageByEncryptoSubject(message);
            return View();
           
        }
    }
}
