namespace DesignPatterns.Observer.Abstractions
{
    /// <summary>
    /// Represents a display element that can display information to the user.
    /// </summary>
    public interface ICustomDisplayElement
    {
        /// <summary>
        /// Displays the current state of the element.
        /// </summary>
        public void Display();
    }
}
