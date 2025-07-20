using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}
