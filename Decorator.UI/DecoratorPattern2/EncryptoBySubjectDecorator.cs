using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }

        public void SendMessageByEncryptoSubject(iMessage message)
        {
            using var _decoContext = new DecoContext();
            string data = "";
            data = message.Subject;
            char[] chars = data.ToCharArray();
            foreach(var item in chars)
            {
                message.Subject += Convert.ToChar(item + 3).ToString();
            }
            _decoContext.iMessages.Add(message);    
            _decoContext.SaveChanges();
        }

        public override void SendMessage(iMessage message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
