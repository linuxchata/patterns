using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Gold indicates an interest bearing state
    /// </summary>
    public class GoldState : State
    {
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(decimal balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            this.Initialize();
        }

        private void Initialize()
        {
            this.Interest = 0.05m;
            this.LowerLimit = 1000m;
            this.UpperLimit = 1000000m;
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
            Console.WriteLine("Interest Paid");
            this.CheckState();
        }

        private void CheckState()
        {
            if (this.Balance < 0m)
            {
                this.Account.State = new RedState(this);
            }
            else if (this.Balance > this.LowerLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }
    }
}
