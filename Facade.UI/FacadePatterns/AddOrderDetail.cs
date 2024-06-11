using Facade.UI.DAL;

namespace Facade.UI.FacadePatterns
{
    public class AddOrderDetail
    {
       

       public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            using var _context = new FacadeContext();
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }
    }
}
