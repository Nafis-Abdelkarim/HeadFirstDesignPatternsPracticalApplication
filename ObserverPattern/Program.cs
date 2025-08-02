using ObserverPattern.Implementations.Displays;
using ObserverPattern.Implementations.Subject;

internal class Program
{
    private static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

        weatherData.SetMeasurements(26.6f, 65f, 1013.1f);
        Console.WriteLine("---");

        weatherData.SetMeasurements(28.4f, 70f, 1012.5f);
        Console.WriteLine("---");

        weatherData.SetMeasurements(22.3f, 90f, 1011.2f);

        Console.ReadLine(); //keep window open
    }
}