using System;

namespace Command2
{
    /// <summary>
    /// The receiver class
    /// </summary>
    public sealed class StockTrade
    {
        public void Buy()
        {
            Console.Write("buy stocks");
        }

        public void Sell()
        {
            Console.Write("sell stocks");
        }
    }
}