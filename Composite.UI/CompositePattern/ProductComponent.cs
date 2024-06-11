namespace Composite.UI.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public int ComponentID { get ; set; }

        public ProductComponent(int componentID, string name)
        {
            ComponentID = componentID;
            Name = name;
        }

        public string Name { get; set ; }

        public string Display()
        {
            return $"< li class='list-group-item'>{Name}</li>";
        }

        public int TotalCount()
        {
            return 1;
        }
    }
}
