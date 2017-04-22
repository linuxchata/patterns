using System;
using Observer.Events;
using Observer.Traditional;
using StockTicker = Observer.Traditional.StockTickerSubject;

namespace Observer
{
    /// <summary>
    /// Define a one-to-many dependency between objects so that when one object
    /// changes state, all its dependents are notified and updated automatically.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Classic Observer");

            var ticker = new StockTicker();
            var google = new GoogleObserver(ticker);
            var microsoft = new MicrosoftObserver(ticker);
            foreach (var item in SampleData.GetNext())
            {
                ticker.Stock = item;
            }

            Console.WriteLine();
            Console.WriteLine("Event and Delegates");

            var stockTicker = new Events.StockTicker();
            var googleMonitor = new GoogleMonitor(stockTicker);
            var microsoftMonitor = new MicrosoftMonitor(stockTicker);
            foreach (var item in SampleData.GetNext())
            {
                stockTicker.Stock = item;
            }

            Console.ReadKey();
        }
    }
}
