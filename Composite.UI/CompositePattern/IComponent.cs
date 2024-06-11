namespace Composite.UI.CompositePattern
{
    public interface IComponent
    {
        public int ComponentID { get; set; }
        public string Name { get; set; }
        int TotalCount();
        string Display();
    }
}
