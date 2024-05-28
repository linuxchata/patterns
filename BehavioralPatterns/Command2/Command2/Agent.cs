using System;
using System.Collections.Generic;

namespace Command2
{
    /// <summary>
    /// The invoker class
    /// </summary>
    public sealed class Agent
    {
        private readonly List<IOrder> _ordersQueue;

        public Agent(string name)
        {
            Name = name;
            _ordersQueue = new List<IOrder>();
        }

        public string Name { get; private set; }

        public void PlaceOrder(IOrder order)
        {
            _ordersQueue.Add(order);
            Console.Write("{0} to ", Name);
            order.Execute();
            Console.WriteLine();
            _ordersQueue.Remove(order);
        }
    }
}