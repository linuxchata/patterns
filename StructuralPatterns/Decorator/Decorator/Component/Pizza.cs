namespace Decorator.Component
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class Pizza
    {
        public abstract string Description { get; }

        public abstract string GetDescription();

        public abstract decimal CalculateCost();
    }
}
