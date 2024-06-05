using CQRSDesign.CQRS.Commands;
using CQRSDesign.DAL;

namespace CQRSDesign.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly CqrsContext _context;

        public CreateProductCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price,
                Strock = command.Strock,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
