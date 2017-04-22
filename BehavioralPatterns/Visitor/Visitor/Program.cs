using System;

namespace Visitor
{
    /// <summary>
    /// Represent an operation to be performed on the elements of an object structure.
    /// Visitor lets you define a new operation without changing the classes of the elements on which it operates.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.02m });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.01m });
            person.Assets.Add(new Loan { Owned = 40000, MonthlyPayment = 400 });

            var netWorth = new NetWorthVisitor();
            person.Accept(netWorth);
            Console.WriteLine(netWorth.Total);

            var income = new MonthlyIncomeVisitor();
            person.Accept(income);
            Console.WriteLine(income.Total);

            Console.ReadKey();
        }
    }
}
