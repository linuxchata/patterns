namespace Strategy
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public sealed class ShippingService
    {
        private readonly IShippingStrategy _strategy;

        public ShippingService(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateShippingCost()
        {
            return _strategy.Calculate();
        }
    }
}
