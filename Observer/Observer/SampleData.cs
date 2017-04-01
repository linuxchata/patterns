using System.Collections.Generic;

namespace Observer
{
    public class SampleData
    {
        private static readonly decimal[] Prices = new[]
        {
            840.3m,
            64.5m,
            66.0m,
            835.7m,
            839.5m,
            67.8m
        };

        private static readonly string[] Names =
        {
            "GOOG",
            "MSFT",
            "MSFT",
            "GOOG",
            "GOOG",
            "MSFT"
        };

        public static IEnumerable<Stock> GetNext()
        {
            for (var i = 0; i < Names.Length; i++)
            {
                var stock = new Stock
                {
                    Name = Names[i],
                    Price = Prices[i]
                };

                yield return stock;
            }
        }
    }
}
