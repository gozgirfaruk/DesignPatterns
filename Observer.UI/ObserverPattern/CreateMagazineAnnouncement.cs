using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ObserverContext _observerContext;

      
        public CreateMagazineAnnouncement(ObserverContext observerContext, IServiceProvider serviceProvider)
        {
            _observerContext = observerContext;
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            _observerContext.UserProcesses.Add(new UserProcess
            {
                Name = appUser.Name + "" + appUser.Surname,
                Magazine ="Bilim Dergisi",
                Content = "Bilim Dergimizin 16.sayısı çıktı"
            });
            _observerContext.SaveChanges();
        }
    }
}
