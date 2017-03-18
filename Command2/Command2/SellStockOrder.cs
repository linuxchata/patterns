namespace Command2
{
    // ConcreteCommand Class
    public class SellStockOrder : IOrder
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