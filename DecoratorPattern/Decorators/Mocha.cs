using StarbuzzWithDecoratorPattern.Beverages;

namespace StarbuzzWithDecoratorPattern.Decorators
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Mocha";

        public override double Cost()
        {
            return _beverage.Cost() + 0.20;
        }
    }
}
