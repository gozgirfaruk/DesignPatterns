using MediatR;

namespace Mediator.UI.MediatorPatern.Commands
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public string StockType { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
