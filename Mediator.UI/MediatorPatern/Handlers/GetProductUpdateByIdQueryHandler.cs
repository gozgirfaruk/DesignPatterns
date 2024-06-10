using Mediator.UI.DAL;
using Mediator.UI.MediatorPatern.Queries;
using Mediator.UI.MediatorPatern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.UI.MediatorPatern.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, UpdateProductByIdQueryResult>
    {
        private readonly MediatContextClass _context;

        public GetProductUpdateByIdQueryHandler(MediatContextClass context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ID);
            return new UpdateProductByIdQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Category = values.Category,
                Price = values.Price,
                Stock = values.Stock,
                StockType = values.StockType
            };
        }
    }
}
