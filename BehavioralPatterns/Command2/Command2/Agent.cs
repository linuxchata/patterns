using System;
using System.Collections.Generic;

namespace Command2
{
    /// <summary>
    /// Invoker
    /// </summary>
    public sealed class Agent
    {
        private List<IOrder> ordersQueue;

        public Agent(string name)
        {
            this.Name = name;
            this.ordersQueue = new List<IOrder>();
        }

        public string Name { get; private set; }

        public void PlaceOrder(IOrder order)
        {
            this.ordersQueue.Add(order);
            Console.Write("{0} to ", this.Name);
            order.Execute();
            Console.WriteLine();
            this.ordersQueue.Remove(order);
        }
    }
}