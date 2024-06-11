using System.Text;

namespace Composite.UI.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public int ComponentID { get; set; }
        public string Name { get; set; }

        private List<IComponent> _components;

        
        public ProductComposite(int componentID, string name)
        {
            ComponentID = componentID;
            Name = name;
            _components= new List<IComponent>();
        }

        public ICollection<IComponent> Components => _components;

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public string Display()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<div class = 'text-success'>{Name} ({TotalCount()})</div>");
            stringBuilder.Append("<ul class = 'list-group list-group-flush ms-2'>");
            foreach(var component in _components)
            {
                stringBuilder.Append(component.Display());
            }
            stringBuilder.Append("</ul>");

            return stringBuilder.ToString();
        }

        public int TotalCount()
        {
            return _components.Sum(x=>x.TotalCount());  
        }
    }
}
