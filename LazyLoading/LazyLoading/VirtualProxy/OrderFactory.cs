namespace LazyLoading.VirtualProxy
{
    public class OrderFactory
    {
        public Order CreateOrder(int id)
        {
            return new OrderProxy { Id = id };
        }
    }
}
