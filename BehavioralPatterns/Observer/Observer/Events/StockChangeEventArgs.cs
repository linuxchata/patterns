using System;

namespace Observer.Events
{
    public class StockChangeEventArgs : EventArgs
    {
        public StockChangeEventArgs(Stock stock)
        {
            Stock = stock;
        }

        public Stock Stock { get; private set; }
    }
}
