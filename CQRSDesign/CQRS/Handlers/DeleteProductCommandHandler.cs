using CQRSDesign.CQRS.Commands;
using CQRSDesign.DAL;

namespace CQRSDesign.CQRS.Handlers
{
    public class DeleteProductCommandHandler
    {
        private readonly CqrsContext _context;

        public DeleteProductCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(DeleteProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
