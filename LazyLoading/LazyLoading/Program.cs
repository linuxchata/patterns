using System;
using LazyLoading.ValueHolder;
using LazyLoading.VirtualProxy;

namespace LazyLoading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Lazy loading
            var orderLazy = new OrderLazy();
            var customer = orderLazy.Customer;
            orderLazy.PrintLabel();

            // Virtual Proxy
            var factory = new OrderFactory();
            var order = factory.CreateOrder(123);
            order.PrintLabel();
            order.PrintLabel();
            order.PrintLabel();

            // Value holder
            var valueOrderFactory = new OrderFactoryValueHolder();
            var factoryOrder = valueOrderFactory.CreareOrder(11);
            var items = factoryOrder.Items;
            var items2 = factoryOrder.Items;
            var items3 = factoryOrder.Items;

            Console.ReadKey();
        }
    }
}
