using ObserverPattern.Interfaces;

namespace ObserverPattern.Implementations.Subject
{
    internal class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }

    }
}
