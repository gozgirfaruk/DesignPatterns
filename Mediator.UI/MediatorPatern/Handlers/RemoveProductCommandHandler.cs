using Mediator.UI.DAL;
using Mediator.UI.MediatorPatern.Commands;
using MediatR;

namespace Mediator.UI.MediatorPatern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly MediatContextClass _context;

        public RemoveProductCommandHandler(MediatContextClass context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values =  _context.Products.Find(request.ID);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
