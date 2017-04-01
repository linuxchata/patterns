using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Silver indicates a non-interest bearing state
    /// </summary>
    public class SilverState : State
    {
        public SilverState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public SilverState(decimal balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            this.Initialize();
        }

        private void Initialize()
        {
            this.Interest = 0m;
            this.LowerLimit = 0m;
            this.UpperLimit = 1000m;
        }

        public override void Deposit(decimal amount)
        {
            this.Balance += amount;
            Console.WriteLine("Deposited {0:0.00}$", amount);
            this.CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            this.Balance -= amount;
            Console.WriteLine("Withdrew {0:0.00}$", amount);
            this.CheckState();
        }

        public override void PayInerest()
        {
            this.Balance += this.Balance * this.Interest;
            this.CheckState();
        }

        private void CheckState()
        {
            if (this.Balance < this.LowerLimit)
            {
                this.Account.State = new RedState(this);
            }
            else if (this.Balance > this.UpperLimit)
            {
                this.Account.State = new GoldState(this);
            }
        }
    }
}
