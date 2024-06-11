using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPatterns
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        private readonly DecoContext _context;
        public MailDecorator(INotifier notifier, DecoContext context) : base(notifier)
        {
            _notifier = notifier;
            _context = context;
        }

        public void SendMailNotifier(Notifier notifier)
        {
            notifier.Subject = "Günlük Sabah Toplantısı";
            notifier.Creator = "Scrum Master";
            notifier.Channel = "Gmail-Outlook";
            notifier.Type = "Private Team";
            _context.Notifiers.Add(notifier);
            _context.SaveChanges();
        }

        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotifier(notifier);
        }

    }
}
