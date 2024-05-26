using System;
using Observer.Events;
using Observer.Traditional;

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

            var stockTickerSubject = new StockTickerSubject();
            var google = new GoogleObserver(stockTickerSubject);
            var microsoft = new MicrosoftObserver(stockTickerSubject);
            foreach (var item in SampleData.GetNext())
            {
                stockTickerSubject.Stock = item;
            }

            Console.WriteLine();
            Console.WriteLine("Event and Delegates");

            var stockTicker = new StockTicker();
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
