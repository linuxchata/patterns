using System;
using System.Net;

namespace Prototype
{
    /// <summary>
    /// A 'ConcretePrototype' class
    /// </summary>
    public class WebPageScraper : ICloneable
    {
        private string title;

        private string body;

        public WebPageScraper(string url)
        {
            var client = new WebClient();
            var uri = new Uri(url);
            Scrape(client.DownloadString(uri));
        }

        public void PrintData()
        {
            Console.WriteLine("Title: {0}", this.title);
            Console.WriteLine("Body: {0}", this.body);
        }

        private void Scrape(string page)
        {
            this.title = "Fake Title";
            this.body = "Fake Body";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
