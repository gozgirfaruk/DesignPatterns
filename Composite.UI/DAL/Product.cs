namespace Composite.UI.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
