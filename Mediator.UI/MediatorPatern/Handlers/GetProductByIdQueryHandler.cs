using Mediator.UI.DAL;
using Mediator.UI.MediatorPatern.Queries;
using Mediator.UI.MediatorPatern.Results;
using MediatR;

namespace Mediator.UI.MediatorPatern.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly MediatContextClass _contextClass;

        public GetProductByIdQueryHandler(MediatContextClass contextClass)
        {
            _contextClass = contextClass;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _contextClass.Products.FindAsync(request.ProductID);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Stock = values.Stock
            };
        }
    }
}
