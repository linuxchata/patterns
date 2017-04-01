namespace Strategy
{
    /// <summary>
    /// The 'Strategy' interface
    /// </summary>
    public interface IShippingStrategy
    {
        string Name { get; }

        decimal Calculate();
    }
}
