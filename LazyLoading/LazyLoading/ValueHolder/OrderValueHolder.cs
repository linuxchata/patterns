using System.Collections.Generic;

namespace LazyLoading.ValueHolder
{
    public class OrderValueHolder
    {
        public int Id { get; set; }

        public OrderValueHolder(int id)
        {
            this.Id = id;
        }

        private ValueHolder<List<OrderItem>> items;

        public List<OrderItem> Items
        {
            get
            {
                return items.Value;
            }
        }

        public void SetItems(ValueHolder<List<OrderItem>> valueHolder)
        {
            this.items = valueHolder;
        }
    }
}
