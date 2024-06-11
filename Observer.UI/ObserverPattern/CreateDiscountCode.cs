using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ObserverContext _observerContext;

        public CreateDiscountCode(ObserverContext observerContext, IServiceProvider serviceProvider)
        {
            _observerContext = observerContext;
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _observerContext.Discounts.Add(new Discount
            {
                Code = "DERGIMAY",
                Amoun = 35,
                Status = true
            });
            _observerContext.SaveChanges();
        }
    }
}
