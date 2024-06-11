using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject(List<IObserver> observers)
        {
            _observers = new List<IObserver>();
        }

        public ObserverObject()
        {
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(AppUser user)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(user);
            });
        }


    }
}
