namespace Command2
{
    // ConcreteCommand Class
    public class BuyStockOrder : IOrder
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