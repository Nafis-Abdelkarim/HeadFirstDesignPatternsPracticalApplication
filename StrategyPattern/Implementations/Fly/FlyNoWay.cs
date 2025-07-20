using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
