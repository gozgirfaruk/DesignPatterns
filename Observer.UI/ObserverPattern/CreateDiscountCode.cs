using Observer.UI.DAL;

namespace Observer.UI.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        public IServiceProvider serviceProvider { get; }
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        

        public void CreateNewUser(AppUser appUser)
        {
            using var _observerContext = new ObserverContext();
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
