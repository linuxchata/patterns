using System.Collections;

namespace Command2
{
    // Invoker
    public class Agent
    {
        private readonly ArrayList ordersQueue = new ArrayList();

        public void PlaceOrder(IOrder order)
        {
            this.ordersQueue.Add(order);
            order.Execute();
            this.ordersQueue.Remove(order);
        }
    }
}