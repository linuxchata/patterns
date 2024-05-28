namespace Command2
{
    /// <summary>
    /// ConcreteCommand class
    /// </summary>
    public sealed class SellStockOrder : IOrder
    {
        private readonly StockTrade _stock;

        public SellStockOrder(StockTrade stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Sell();
        }
    }
}