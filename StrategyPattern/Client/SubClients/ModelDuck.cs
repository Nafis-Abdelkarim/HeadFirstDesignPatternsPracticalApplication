using StrategyPattern.Implementations.Fly;
using StrategyPattern.Implementations.Quack;
using StrategyPattern.Models;

namespace StrategyPattern.Client.SubClients
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
