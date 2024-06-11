using Facade.UI.DAL;

namespace Facade.UI.FacadePatterns
{
    public class ProductStock
    {

        public void StockDecrease(int id , int amount)
        {
            using var _context = new FacadeContext();
            var value = _context.Products.Find(id);
            value.Stock -=amount;
            _context.SaveChanges();
        }
    }
}
