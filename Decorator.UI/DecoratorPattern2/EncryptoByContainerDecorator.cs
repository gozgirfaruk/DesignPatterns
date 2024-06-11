using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPattern2
{
    public class EncryptoByContainerDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        private readonly DecoContext _decoContext;
        public EncryptoByContainerDecorator(ISendMessage sendMessage, DecoContext decoContext) : base(sendMessage)
        {
            _sendMessage = sendMessage;
            _decoContext = decoContext;
        }
        public void SendMessageByEncryptoByContainer(iMessage message)
        {
            string data = "";
            data = message.Container;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.Container += Convert.ToChar(item + 3).ToString();
            }
            _decoContext.iMessages.Add(message);
            _decoContext.SaveChanges();
        }
        public override void SendMessage(iMessage message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoByContainer(message);
        }
    }
}
