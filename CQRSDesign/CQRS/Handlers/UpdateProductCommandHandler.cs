using CQRSDesign.CQRS.Commands;
using CQRSDesign.DAL;

namespace CQRSDesign.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CqrsContext _context;

        public UpdateProductCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.Name = command.Name;
            values.Description = command.Description;
            values.Price = command.Price;
            values.Strock= command.Strock;
            values.Status = true;
            _context.Products.Update(values);
            _context.SaveChanges();
        }
    }
}
