using Mediator.UI.DAL;
using Mediator.UI.MediatorPatern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.UI.MediatorPatern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly MediatContextClass _context;

        public CreateProductCommandHandler(MediatContextClass context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                Name = request.Name,
                Category = request.Category,
                Price = request.Price,
                Stock = request.Stock,
                StockType = request.StockType
            });
            await _context.SaveChangesAsync();
        }
    }
}
