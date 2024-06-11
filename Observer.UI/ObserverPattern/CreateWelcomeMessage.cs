using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    { 
        public IServiceProvider serviceProvider { get; }
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
           this.serviceProvider = serviceProvider;
        }

       

        public void CreateNewUser(AppUser appUser)
        {
            using var _observerContext=new ObserverContext();
            _observerContext.WelcomeMessages.Add(new WelcomeMessage
            {
                Name = appUser.Name + "" + appUser.Surname,
                Content = "Dergi bültenimize kayıt olduğunuz için teşekkür ederiz."

            });
            _observerContext.SaveChanges();
        }
    }
}
