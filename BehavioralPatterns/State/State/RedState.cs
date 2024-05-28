using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Red indicates that account is overdrawn
    /// </summary>
    public sealed class RedState : State
    {
        public RedState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public RedState(decimal balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
            Interest = 0m;
            LowerLimit = -100m;
            UpperLimit = 0m;
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Deposited {0:0.00}$", amount);
            CheckState();
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
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}
