using System;

namespace Rules
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "John Oliver",
                DateOfBirth = new DateTime(1977, 1, 11),
                DateOfFirstPurchase = new DateTime(2015, 1, 05)
            };

            var customer2 = new Customer
            {
                Name = "John Cash",
                DateOfBirth = new DateTime(1939, 5, 17),
                DateOfFirstPurchase = new DateTime(2015, 1, 05)
            };

            var customer3 = new Customer
            {
                Name = "John Rembo",
                DateOfBirth = new DateTime(1969, 9, 23),
                IsVeteran = true,
                DateOfFirstPurchase = new DateTime(2015, 1, 05)
            };

            var discountRuleCalculator = new DiscountRuleCalculator();
            Console.WriteLine("Discount for {0} is {1}%", customer.Name, discountRuleCalculator.CalculateDiscont(customer));

            Console.WriteLine("Discount for {0} is {1}%", customer2.Name, discountRuleCalculator.CalculateDiscont(customer2));

            Console.WriteLine("Discount for {0} is {1}%", customer3.Name, discountRuleCalculator.CalculateDiscont(customer3));

            Console.ReadKey();
        }
    }
}
