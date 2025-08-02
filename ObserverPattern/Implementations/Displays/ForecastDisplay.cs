using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations.Displays
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 1013f;
        private float lastPressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if(currentPressure > lastPressure)
            {
                Console.WriteLine("Improveing weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather.");
            }
        }
    }
}
