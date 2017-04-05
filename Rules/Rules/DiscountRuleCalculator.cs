using System;
using System.Collections.Generic;

namespace Rules
{
    public class DiscountRuleCalculator
    {
        private readonly IList<IDiscountRule> rules;

        public DiscountRuleCalculator()
        {
            this.rules = new List<IDiscountRule>
            {
                new BirthdayDiscountRule(),
                new SeniorRule(),
                new VeteranRule()
            };
        }

        public decimal CalculateDiscont(Customer customer)
        {
            decimal discount = 0;

            foreach (var rule in this.rules)
            {
                discount = Math.Max(rule.CalcumateDiscount(customer), discount);
            }

            return discount;
        }
    }
}
