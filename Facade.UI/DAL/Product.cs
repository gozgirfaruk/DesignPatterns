namespace Facade.UI.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }





    }
}
