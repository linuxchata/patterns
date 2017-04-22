using System;

namespace Strategy
{
    /// <summary>
    /// Define a family of algorithms, encapsulate each one, and make them interchangeable.
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            IShippingStrategy strategy1 = new DhlShippingStrategy();
            var service = new ShippingService(strategy1);
            Console.WriteLine("{0} cost is {1}$", strategy1.Name, service.CalculateShippingCost());

            IShippingStrategy strategy2 = new UpsShippingStrategy();
            service = new ShippingService(strategy2);
            Console.WriteLine("{0} cost is {1}$", strategy2.Name, service.CalculateShippingCost());

            Console.ReadKey();
        }
    }
}
