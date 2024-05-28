using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Gold indicates an interest bearing state
    /// </summary>
    public sealed class GoldState : State
    {
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(decimal balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
            Interest = 0.05m;
            LowerLimit = 1000m;
            UpperLimit = 1000000m;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Deposited {0:0.00}$", amount);
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine("Withdrew {0:0.00}$", amount);
            CheckState();
        }

        public override void PayInerest()
        {
            Balance += this.Balance * this.Interest;
            Console.WriteLine("Interest Paid");
            CheckState();
        }

        private void CheckState()
        {
            if (Balance < 0m)
            {
                Account.State = new RedState(this);
            }
            else if (Balance > LowerLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}
