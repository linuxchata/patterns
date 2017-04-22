namespace State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class State
    {
        protected decimal Interest;

        protected decimal LowerLimit;

        protected decimal UpperLimit;

        public Account Account { get; set; }

        public decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public abstract void PayInerest();
    }
}
