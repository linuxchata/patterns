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
            // The receiver class
            var stockTrade = new StockTrade();

            // Concrete commands classes
            var buyStockOrder = new BuyStockOrder(stockTrade);
            var sellStockOrder = new SellStockOrder(stockTrade);

            // The invoker class
            var agent = new Agent("Patrik Bank");
            agent.PlaceOrder(buyStockOrder); // Buy shares
            agent.PlaceOrder(sellStockOrder); // Sell shares

            Console.ReadKey();
        }
    }
}
