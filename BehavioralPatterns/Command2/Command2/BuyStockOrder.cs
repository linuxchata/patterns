namespace Command2
{
    /// <summary>
    /// ConcreteCommand Class
    /// </summary>
    public sealed class BuyStockOrder : IOrder
    {
        private readonly StockTrade stock;

        public BuyStockOrder(StockTrade stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            this.stock.Buy();
        }
    }
}