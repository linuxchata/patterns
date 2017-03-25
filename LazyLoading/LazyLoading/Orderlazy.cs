using System;

namespace LazyLoading
{
    public class OrderLazy
    {
        private readonly Lazy<Customer> customer;

        public OrderLazy()
        {
            this.customer = new Lazy<Customer>(() => new Customer { CompanyName = "Apple", Address = "CA" }, false);
        }

        public Customer Customer
        {
            get
            {
                return this.customer.Value;
            }
        }

        public void PrintLabel()
        {
            Console.WriteLine(this.Customer.CompanyName + ", " + this.Customer.Address);
        }
    }
}
