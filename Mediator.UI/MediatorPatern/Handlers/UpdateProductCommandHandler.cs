using Mediator.UI.DAL;
using Mediator.UI.MediatorPatern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.UI.MediatorPatern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly MediatContextClass _context;

        public UpdateProductCommandHandler(MediatContextClass context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ProductID);
            value.Name = request.Name;
            value.Stock = request.Stock;
            value.Price = request.Price;
            value.Category = request.Category;
            value.StockType = request.StockType;
            await _context.SaveChangesAsync();

        }
    }
}
