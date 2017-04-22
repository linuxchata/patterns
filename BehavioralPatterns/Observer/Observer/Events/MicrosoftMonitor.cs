using System;

namespace Observer.Events
{
    public class MicrosoftMonitor
    {
        public MicrosoftMonitor(StockTicker stockTicker)
        {
            stockTicker.StockChange += StockTickerOnStockChange;
        }

        private void StockTickerOnStockChange(object sender, StockChangeEventArgs e)
        {
            if (string.Equals(e.Stock.Name, "MSFT"))
            {
                Console.WriteLine("{0} stock is at {1}$.", e.Stock.Name, e.Stock.Price);
            }
        }
    }
}
