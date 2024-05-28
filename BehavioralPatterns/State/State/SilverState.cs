using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Silver indicates a non-interest bearing state
    /// </summary>
    public sealed class SilverState : State
    {
        public SilverState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public SilverState(decimal balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
            Interest = 0m;
            LowerLimit = 0m;
            UpperLimit = 1000m;
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
            Balance += Balance * Interest;
            CheckState();
        }

        private void CheckState()
        {
            if (Balance < LowerLimit)
            {
                Account.State = new RedState(this);
            }
            else if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }
}
