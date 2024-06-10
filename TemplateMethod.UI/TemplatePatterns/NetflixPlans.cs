namespace TemplateMethod.UI.TemplatePatterns
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlansType(string.Empty);
            CountPerson(0);
            Price(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }
        public abstract string PlansType(string type);
        public abstract int CountPerson(int person);
        public abstract double Price(double price);
        public abstract string Resolution(string resolution);
        public abstract string Content(string content);
    }
}
