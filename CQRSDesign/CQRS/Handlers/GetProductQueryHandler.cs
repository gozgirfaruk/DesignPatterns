using CQRSDesign.CQRS.Results;
using CQRSDesign.DAL;

namespace CQRSDesign.CQRS.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly CqrsContext _context;

        public GetProductQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Price = x.Price,
                Strock = x.Strock
            }).ToList();
            return values;
        }
    }
}
