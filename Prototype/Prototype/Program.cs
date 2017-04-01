using System;

namespace Prototype
{
    /// <summary>
    /// Specify the kind of objects to create using a prototypical instance,
    /// and create new objects by copying this prototype.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var webPageScraper = new WebPageScraper("http://google.com");
            webPageScraper.PrintData();

            var webPageScraper2 = webPageScraper.Clone() as WebPageScraper;
            webPageScraper2.PrintData();

            Console.ReadKey();
        }
    }
}
