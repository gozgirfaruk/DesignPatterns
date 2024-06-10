using Mediator.UI.MediatorPatern.Results;
using MediatR;

namespace Mediator.UI.MediatorPatern.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<UpdateProductByIdQueryResult>
    {
        public int ID { get; set; }

        public GetProductUpdateByIdQuery(int ıD)
        {
            ID = ıD;
        }
    }
}
