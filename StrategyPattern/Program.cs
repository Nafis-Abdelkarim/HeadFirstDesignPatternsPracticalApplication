using StrategyPattern.Client.SubClients;
using StrategyPattern.Implementations.Fly;
using StrategyPattern.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.Display();
        mallard.PerformQuack();
        mallard.PerformFly();

        Console.WriteLine();

        Duck model = new ModelDuck();
        model.Display();
        model.PerformFly();

        Console.WriteLine("Chaning behavior at runtime...");
        model.SetFlyBehavior(new FlyWithWings());
        model.PerformFly();  
    }
}