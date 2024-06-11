using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        private readonly DecoContext _decoContext;
        public EncryptoBySubjectDecorator(ISendMessage sendMessage, DecoContext decoContext) : base(sendMessage)
        {
            _sendMessage = sendMessage;
            _decoContext = decoContext;
        }
        public void SendMessageByEncryptoSubject(iMessage message)
        {
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
