using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
