using System;

namespace State
{
    /// <summary>
    /// Allow an object to alter its behavior when its internal state changes. 
    /// The object will appear to change its class.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Open a new account
            var account = new Account("Jim Oliver");

            // Apply financial transactions
            account.Deposit(500m);
            account.Deposit(300m);
            account.Deposit(550m);
            account.PayInterest();
            account.Withdraw(2000m);
            account.Withdraw(1100m);
            account.PayInterest();

            Console.ReadKey();
        }
    }
}
