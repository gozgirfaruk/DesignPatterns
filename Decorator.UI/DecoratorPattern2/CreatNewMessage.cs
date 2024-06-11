using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPattern2
{
    public class CreatNewMessage : ISendMessage
    {
        

        public void SendMessage(iMessage message)
        {
            using var _context = new DecoContext();
            _context.iMessages.Add(message);
            _context.SaveChanges();
        }
    }
}
