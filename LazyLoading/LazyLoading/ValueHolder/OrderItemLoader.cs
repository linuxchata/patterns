using System;
using System.Collections.Generic;

namespace LazyLoading.ValueHolder
{
    public class OrderItemLoader : IValueLoader<List<OrderItem>>
    {
        private readonly int orderId;

        public OrderItemLoader(int orderId)
        {
            this.orderId = orderId;
        }

        public List<OrderItem> Load()
        {
            Console.WriteLine("Fetching data from database for order " + this.orderId + ".");
            return new List<OrderItem>
            {
                new OrderItem()
            };
        }
    }
}
