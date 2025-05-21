using DesignPatterns.Observer.Abstractions;
using System.Collections;

namespace DesignPatterns.Observer
{
    public class WeatherData : ICustomSubject
    {
        private readonly ArrayList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = [];
        }

        public void NotifyObserver()
        {
            foreach(var observer in _observers)
            {
                if (observer is ICustomObserver customObserver)
                    customObserver.Update(_temperature, _humidity, _pressure);
                else
                    throw new InvalidCastException("Observer is not of type ICustomObserver");
            }
        }

        public void RegisterObserver(ICustomObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(ICustomObserver observer)
        {
            if(_observers.IndexOf(observer) >=0)
            {
                _observers.Remove(observer);
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();   
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }
    }
}
