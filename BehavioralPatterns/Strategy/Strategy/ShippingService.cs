namespace Strategy
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public sealed class ShippingService
    {
        private readonly IShippingStrategy strategy;

        public ShippingService(IShippingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public decimal CalculateShippingCost()
        {
            return this.strategy.Calculate();
        }
    }
}
