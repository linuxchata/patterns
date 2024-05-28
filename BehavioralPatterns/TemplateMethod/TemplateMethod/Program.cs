using System;

namespace TemplateMethod
{
    /// <summary>
    /// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
    /// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("UPS");
            OrderShipment orderShipment = new UpsOrderShipment("Wroclaw");
            orderShipment.Ship();

            Console.WriteLine();

            Console.WriteLine("FEDEX");
            orderShipment = new FedexOrderShipment("Wroclaw");
            orderShipment.Ship();

            Console.ReadKey();
        }
    }
}
