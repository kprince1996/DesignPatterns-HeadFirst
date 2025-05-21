namespace DesignPatterns.Observer.Abstractions
{
    /// <summary>
    /// Defines a contract for observers that receive updates about temperature, humidity, and pressure changes.
    /// </summary>
    public interface ICustomObserver
    {
        /// <summary>
        /// Called when the observed subject's state changes.
        /// </summary>
        /// <param name="temp">The current temperature value.</param>
        /// <param name="humidity">The current humidity value.</param>
        /// <param name="pressure">The current pressure value.</param>
        void Update(float temp, float humidity, float pressure);
    }
}
