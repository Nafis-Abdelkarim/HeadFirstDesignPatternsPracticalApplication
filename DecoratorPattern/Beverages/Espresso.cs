namespace StarbuzzWithDecoratorPattern.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
