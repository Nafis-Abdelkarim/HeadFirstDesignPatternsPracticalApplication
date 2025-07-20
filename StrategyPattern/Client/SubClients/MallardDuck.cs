using StrategyPattern.Implementations.Fly;
using StrategyPattern.Implementations.Quack;
using StrategyPattern.Models;

namespace StrategyPattern.Client.SubClients
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}
