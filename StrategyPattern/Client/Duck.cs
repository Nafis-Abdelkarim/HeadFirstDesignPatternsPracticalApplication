using StrategyPattern.Interfaces;

namespace StrategyPattern.Models
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quacking();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        // we can change the behavior by the runtime using
        // the passed parameter is going to be the implementation of the Iinterface
        public void SetFlyBehavior(IFlyBehavior fb)
        { 
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb) 
        {
            quackBehavior = qb;
        }

        public abstract void Display();
    }
}
