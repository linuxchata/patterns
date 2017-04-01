using System;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IShippingStrategy strategy = new DhlShippingStrategy();
            var service = new ShippingService(strategy);
            Console.WriteLine("{0} cost is {1}$", strategy.Name, service.CalculateShippingCost());

            strategy = new UpsShippingStrategy();
            service = new ShippingService(strategy);
            Console.WriteLine("{0} cost is {1}$", strategy.Name, service.CalculateShippingCost());

            Console.ReadKey();
        }
    }
}
