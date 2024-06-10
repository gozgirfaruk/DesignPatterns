using MediatR;

namespace Mediator.UI.MediatorPatern.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveProductCommand(int ıD)
        {
            ID = ıD;
        }
    }
}
