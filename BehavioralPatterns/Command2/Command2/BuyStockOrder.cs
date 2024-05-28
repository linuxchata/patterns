namespace Command2
{
    /// <summary>
    /// ConcreteCommand class
    /// </summary>
    public sealed class BuyStockOrder : IOrder
    {
        private readonly StockTrade _stock;

        public BuyStockOrder(StockTrade stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Buy();
        }
    }
}