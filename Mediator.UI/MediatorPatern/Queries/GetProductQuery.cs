using Mediator.UI.MediatorPatern.Results;
using MediatR;

namespace Mediator.UI.MediatorPatern.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {
    }
}
