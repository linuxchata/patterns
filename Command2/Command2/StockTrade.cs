using System;

namespace Command2
{
    // Receiver class
    public class StockTrade
    {
        public void Buy()
        {
            Console.WriteLine("You want to buy stocks");
        }
        public void Sell()
        {
            Console.WriteLine("You want to sell stocks ");
        }
    }
}