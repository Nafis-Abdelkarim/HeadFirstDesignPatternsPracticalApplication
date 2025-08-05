using StarbuzzWithDecoratorPattern.Beverages;

namespace StarbuzzWithDecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string  Description { get; }
    }
}
