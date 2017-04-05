using System;

namespace Rules
{
    public class SeniorRule : IDiscountRule
    {
        public decimal CalcumateDiscount(Customer customer)
        {
            if (customer.DateOfBirth < DateTime.Today.AddYears(-65))
            {
                return 0.05m;
            }

            return 0;
        }
    }
}