using CQRSDesign.CQRS.Queries;
using CQRSDesign.CQRS.Results;
using CQRSDesign.DAL;

namespace CQRSDesign.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CqrsContext _context;

        public GetProductByIdQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Products.Find(query.ProductID);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Price = values.Price,
                Strock = values.Strock
            };
        }
    }
}
