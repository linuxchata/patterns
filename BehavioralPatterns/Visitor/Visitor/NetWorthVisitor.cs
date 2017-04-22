namespace Visitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public sealed class NetWorthVisitor : IVisitor
    {
        public decimal Total { get; set; }

        public void Visit(RealEstate realEstate)
        {
            this.Total += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            this.Total += bankAccount.Amount;
        }

        public void Visit(Loan loan)
        {
            this.Total -= loan.Owned;
        }
    }
}
