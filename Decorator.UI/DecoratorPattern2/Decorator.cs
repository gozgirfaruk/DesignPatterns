using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {
       
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }
     virtual public void SendMessage(iMessage message)
        {
            message.Receiver = "Everybody";
            message.Sender = "Admin";
            message.Container = "Merhaba bu bir deneme mesajıdır.";
            message.Subject = "Deneme";
            _sendMessage.SendMessage(message);
            
        }
    }
}
