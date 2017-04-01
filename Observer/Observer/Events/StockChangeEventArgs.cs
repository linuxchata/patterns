using System;

namespace Observer.Events
{
    public class StockChangeEventArgs : EventArgs
    {
        public StockChangeEventArgs(Stock stock)
        {
            this.Stock = stock;
        }

        public Stock Stock { get; private set; }
    }
}
