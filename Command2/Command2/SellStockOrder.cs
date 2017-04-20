namespace Command2
{
    /// <summary>
    /// ConcreteCommand Class
    /// </summary>
    public sealed class SellStockOrder : IOrder
    {
        private readonly StockTrade stock;

        public SellStockOrder(StockTrade stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            this.stock.Sell();
        }
    }
}