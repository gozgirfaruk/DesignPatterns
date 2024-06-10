namespace Iterator.UI.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes=new List<VisitRoute>();

        public void AddVisitRoute(VisitRoute visitRoute)
        {
            visitRoutes.Add(visitRoute);
        }

        public int VisitRouteCount { get => visitRoutes.Count; }
        public IIterator<VisitRoute> CreateIterator()
        {
            //bir şeyler dönecek burada hissediyorum.
            return new VisitRouteIterator(this);
        }
    }
}
