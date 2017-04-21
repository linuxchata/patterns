using System;

namespace Command2
{
    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parameterize clients
    /// with different requests, queue or log requests, and support undoable operations.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var stock = new StockTrade();

            var buyStockOrder = new BuyStockOrder(stock);
            var sellStockOrder = new SellStockOrder(stock);

            var agent = new Agent("Patrik Bank");
            agent.PlaceOrder(buyStockOrder); // Buy Shares
            agent.PlaceOrder(sellStockOrder); // Sell Shares

            Console.ReadKey();
        }
    }
}
