using System;
using System.Collections;

namespace Command2
{
    /// <summary>
    /// Invoker
    /// </summary>
    public sealed class Agent
    {
        private readonly ArrayList ordersQueue = new ArrayList();

        public Agent(string name)
        {
            this.Name = name;
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