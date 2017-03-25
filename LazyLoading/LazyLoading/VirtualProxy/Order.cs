using System;

namespace LazyLoading.VirtualProxy
{
    public class Order
    {
        public int Id { get; set; }

        public virtual Customer Customer { get; set; }

        public void PrintLabel()
        {
            Console.WriteLine(this.Customer.CompanyName + ", " + this.Customer.Address);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
