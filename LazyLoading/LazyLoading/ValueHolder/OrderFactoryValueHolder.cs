using System.Collections.Generic;

namespace LazyLoading.ValueHolder
{
    public class OrderFactoryValueHolder
    {
        public OrderValueHolder CreareOrder(int id)
        {
            var valueOrder = new OrderValueHolder(11);
            valueOrder.SetItems(new ValueHolder<List<OrderItem>>(new OrderItemLoader(id)));
            return valueOrder;
        }
    }
}
