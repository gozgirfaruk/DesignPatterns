using Decorator.UI.DAL;

namespace Decorator.UI.DecoratorPatterns
{
    public class CreateNotifier : INotifier
    {
        private readonly DecoContext _context;

        public CreateNotifier(DecoContext context)
        {
            _context = context;
        }

        public void CreateNotify(Notifier notifier)
        {
            _context.Notifiers.Add(notifier);
            _context.SaveChanges();
        }
    }
}
