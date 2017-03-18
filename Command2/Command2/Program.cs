using System;

namespace Command2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new StockTrade();

            var buyStockOrder = new BuyStockOrder(stock);
            var sellStockOrder = new SellStockOrder(stock);

            var agent = new Agent();
            agent.PlaceOrder(buyStockOrder); // Buy Shares
            agent.PlaceOrder(sellStockOrder); // Sell Shares

            Console.ReadKey();
        }
    }
}
