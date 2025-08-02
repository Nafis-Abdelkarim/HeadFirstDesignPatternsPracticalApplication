using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations.Displays
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = float.MaxValue;
        private float minTemp = float.MinValue;
        private float tempSum = 0f;
        private int numReadings;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp) 
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp) 
            {
                minTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            float avgTemp = tempSum / numReadings;
            Console.WriteLine($"Avg/Max/Min temperature = {avgTemp:0.0}/{maxTemp}/{minTemp}");
        }
    }
}
