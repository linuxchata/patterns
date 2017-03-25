using System;

namespace LazyLoading.VirtualProxy
{
    public class OrderProxy : Order
    {
        public override Customer Customer
        {
            get
            {
                if (base.Customer == null)
                {
                    base.Customer = new Customer
                    {
                        CompanyName = "ABC",
                        Address = "CA"
                    };
                    Console.WriteLine("Init a new customer");
                }

                return base.Customer;
            }
            set
            {
                base.Customer = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Order;
            if (other == null)
            {
                return false;
            }
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
