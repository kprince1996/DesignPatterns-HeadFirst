namespace DesignPatterns.Observer.Abstractions
{
    /// <summary>
    /// Represents a subject in the Observer pattern that can register, remove, and notify observers.
    /// </summary>
    public interface ICustomSubject
    {
        /// <summary>
        /// Registers an observer to receive notifications from this subject.
        /// </summary>
        /// <param name="observer">The observer to register.</param>
        void RegisterObserver(ICustomObserver observer);

        /// <summary>
        /// Removes a previously registered observer.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        void RemoveObserver(ICustomObserver observer);

        /// <summary>
        /// Notifies all registered observers of a change.
        /// </summary>
        void NotifyObserver();
    }
}
