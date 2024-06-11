using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPattern2
{
    public class CreatNewMessage : ISendMessage
    {
        private readonly DecoContext _context;


        public CreatNewMessage(DecoContext context)
        {
            _context = context;
        }

        public void SendMessage(iMessage message)
        {
            _context.iMessages.Add(message);
            _context.SaveChanges();
        }
    }
}
