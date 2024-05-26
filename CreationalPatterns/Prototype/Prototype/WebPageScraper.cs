using System;
using System.Net;

namespace Prototype
{
    /// <summary>
    /// A 'ConcretePrototype' class
    /// </summary>
    public class WebPageScraper : ICloneable
    {
        private string _title;

        private string _body;

        public WebPageScraper(string url)
        {
            var client = new WebClient();
            var uri = new Uri(url);
            Scrape(client.DownloadString(uri));
        }

        public void PrintData()
        {
            Console.WriteLine("Title: {0}", _title);
            Console.WriteLine("Body: {0}", _body);
        }

        private void Scrape(string page)
        {
            _title = "Fake Title";
            _body = "Fake Body";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
