namespace Rules
{
    public class VeteranRule : IDiscountRule
    {
        public decimal CalcumateDiscount(Customer customer)
        {
            if (customer.IsVeteran)
            {
                return 0.11m;
            }

            return 0;
        }
    }
}
