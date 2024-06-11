using Facade.UI.DAL;

namespace Facade.UI.FacadePatterns
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderdetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddORder addOrder = new AddORder();
        AddOrderDetail addorderDetail=new AddOrderDetail();

        public void CompleteOrder(int customerID, int productID, int productCount,decimal productPrice)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);

           // orderdetail.OrderID = orderID;
            orderdetail.CustomerID = customerID;
            orderdetail.ProductID = productID;
            orderdetail.ProductCount = productCount;
            orderdetail.Price = productPrice;
           decimal tatalProductPrice = productCount * productPrice;
            orderdetail.TotalPrice = tatalProductPrice;
            addorderDetail.AddNewOrderDetail(orderdetail);


            productStock.StockDecrease(productID, productCount);
        }

    }
}
