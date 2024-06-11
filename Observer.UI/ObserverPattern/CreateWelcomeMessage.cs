using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ObserverContext _observerContext;

     
        public CreateWelcomeMessage(ObserverContext observerContext, IServiceProvider serviceProvider)
        {
            _observerContext = observerContext;
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _observerContext.WelcomeMessages.Add(new WelcomeMessage
            {
                Name = appUser.Name + "" + appUser.Surname,
                Content = "Dergi bültenimize kayıt olduğunuz için teşekkür ederiz."

            });
            _observerContext.SaveChanges();
        }
    }
}
