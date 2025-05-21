using DesignPatterns.Observer.Abstractions;

namespace DesignPatterns.Observer
{
    public class CurrentConditionsDisplay : ICustomObserver, ICustomDisplayElement
    {
        private readonly ICustomSubject _customSubject;
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(ICustomSubject customSubject)
        {
            _customSubject = customSubject;
            _customSubject.RegisterObserver(this);
        }

        public void Display()
        {
            var displayText = $"Current condition: {_temperature}F degress and {_humidity}% humidity";
            Console.WriteLine(displayText);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;

            Display();
        }
    }
}
