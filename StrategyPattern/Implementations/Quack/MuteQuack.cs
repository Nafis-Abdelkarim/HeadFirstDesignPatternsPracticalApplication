using StrategyPattern.Interfaces;

namespace StrategyPattern.Implementations.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quacking()
        {
            Console.WriteLine("<<< Silence >>>");
        }
    }
}
