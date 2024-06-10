namespace TemplateMethod.UI.TemplatePatterns
{
    public class StandartPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int person)
        {
            return person;
        }

        public override string PlansType(string type)
        {
            return type;
        }

        public override double Price(double price)
        {
           return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
