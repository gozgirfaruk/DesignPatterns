using System.ComponentModel.DataAnnotations;

namespace Facade.UI.DAL
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int? ProductID { get; set; }
        public Product Product { get; set; }
        public int? CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int ProductCount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int? OrderID { get; set; }
        public Order Order { get; set; }
    }
}
