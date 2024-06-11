namespace Composite.UI.DAL
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int UpperCategoryID { get; set; }
        public List<Product> Products { get; set; }

    }
}
