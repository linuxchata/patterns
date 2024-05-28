using System;

namespace State
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Account
    {
        private readonly string _owner;

        public Account(string owner)
        {
            _owner = owner;
            State = new SilverState(0m, this);
        }

        public State State { get; set; }

        public decimal Balance
        {
            get { return State.Balance; }
        }

        public void Deposit(decimal amount)
        {
            State.Deposit(amount);
            Console.WriteLine("Balance = {0:0.00}$", Balance);
            Console.WriteLine("Status = {0}", State.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(decimal amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("Balance = {0:0.00}$", Balance);
            Console.WriteLine("Status = {0}", State.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterest()
        {
            State.PayInerest();
            Console.WriteLine("Balance = {0:0.00}$", Balance);
            Console.WriteLine("Status = {0}", State.GetType().Name);
            Console.WriteLine();
        }
    }
}
