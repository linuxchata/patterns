using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Red indicates that account is overdrawn
    /// </summary>
    public class RedState : State
    {
        public RedState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public RedState(decimal balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            this.Initialize();
        }

        private void Initialize()
        {
            this.Interest = 0m;
            this.LowerLimit = -100m;
            this.UpperLimit = 0m;
        }

        public override void Deposit(decimal amount)
        {
            this.Balance += amount;
            Console.WriteLine("Deposited {0:0.00}$", amount);
            this.CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInerest()
        {
            Console.WriteLine("No Interest Paid");
        }

        private void CheckState()
        {
            if (this.Balance > this.UpperLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }
    }
}
