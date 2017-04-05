using System;

namespace Rules
{
    public class BirthdayDiscountRule : IDiscountRule
    {
        public decimal CalcumateDiscount(Customer customer)
        {
            if (customer.DateOfBirth.Month == DateTime.Now.Month &&
                customer.DateOfBirth.Day == DateTime.Now.Day)
            {
                return 0.1m;
            }

            return 0;
        }
    }
}
