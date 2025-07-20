using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations.Quack
{
    public class Quack : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Quack!");
        }
    }
}
