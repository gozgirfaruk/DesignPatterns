using Mediator.UI.DAL;
using Mediator.UI.MediatorPatern.Queries;
using Mediator.UI.MediatorPatern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Mediator.UI.MediatorPatern.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly MediatContextClass _context;

        public GetProductQueryHandler(MediatContextClass context)
        {
            _context = context;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Category = x.Category,
                Price = x.Price,
                Stock = x.Stock,
                StockType = x.StockType
            }).AsNoTracking().ToListAsync();


        }
    }
}
