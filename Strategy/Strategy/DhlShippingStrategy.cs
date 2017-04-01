namespace Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class DhlShippingStrategy : IShippingStrategy
    {
        public DhlShippingStrategy()
        {
            Name = "DHL";
        }

        public string Name { get; private set; }

        public decimal Calculate()
        {
            return 5m;
        }
    }
}
