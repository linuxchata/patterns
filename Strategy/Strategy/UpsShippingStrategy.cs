namespace Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public sealed class UpsShippingStrategy : IShippingStrategy
    {
        public UpsShippingStrategy()
        {
            this.Name = "UPS";
        }

        public string Name { get; private set; }

        public decimal Calculate()
        {
            return 3m;
        }
    }
}
