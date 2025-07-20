using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations.Quack
{
    public class Squeak : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
