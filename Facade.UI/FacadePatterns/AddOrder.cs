using Facade.UI.DAL;

namespace Facade.UI.FacadePatterns
{
    public class AddORder
    {
      

        public void AddNewOrder(Order order)
        {
            using var _context = new FacadeContext();
            order.OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _context.Orders.Add(order);
            _context.SaveChanges();
        }



    }
}
