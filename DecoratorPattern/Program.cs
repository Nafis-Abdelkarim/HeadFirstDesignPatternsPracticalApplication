using StarbuzzWithDecoratorPattern.Beverages;
using StarbuzzWithDecoratorPattern.Decorators;

public class Program
{
    private static void Main(string[] args)
    {
        Beverage beverage1 = new Espresso();
        Console.WriteLine($"{beverage1.Description} ${beverage1.Cost():0.00}");

        Beverage beverage2 = new HouseBlend();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.Description} ${beverage2.Cost():0.00}");

        Console.WriteLine();
    }
}