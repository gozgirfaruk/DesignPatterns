using Mediator.UI.MediatorPatern.Results;
using MediatR;

namespace Mediator.UI.MediatorPatern.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public GetProductByIdQuery(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
