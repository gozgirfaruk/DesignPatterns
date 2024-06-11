using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider serviceProvider;

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
         
        }

        public void CreateNewUser(AppUser appUser)
        {
            using var _observerContext = new ObserverContext();
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
