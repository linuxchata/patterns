using System;

namespace State
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Account
    {
        private readonly string owner;

        public Account(string owner)
        {
            this.owner = owner;
            this.State = new SilverState(0m, this);
        }

        public State State { get; set; }

        public decimal Balance
        {
            get { return this.State.Balance; }
        }

        public void Deposit(decimal amount)
        {
            this.State.Deposit(amount);
            Console.WriteLine("Balance = {0:0.00}$", this.Balance);
            Console.WriteLine("Status = {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(decimal amount)
        {
            this.State.Withdraw(amount);
            Console.WriteLine("Balance = {0:0.00}$", this.Balance);
            Console.WriteLine("Status = {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterest()
        {
            this.State.PayInerest();
            Console.WriteLine("Balance = {0:0.00}$", this.Balance);
            Console.WriteLine("Status = {0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}
