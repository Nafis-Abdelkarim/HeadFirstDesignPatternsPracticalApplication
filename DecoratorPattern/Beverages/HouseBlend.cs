namespace StarbuzzWithDecoratorPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Conffee";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
