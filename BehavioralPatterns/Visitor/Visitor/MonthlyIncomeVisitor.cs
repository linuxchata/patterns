namespace Visitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public sealed class MonthlyIncomeVisitor : IVisitor
    {
        public decimal Total { get; set; }

        public void Visit(RealEstate realEstate)
        {
            this.Total += realEstate.MonthlyRent;
        }

        public void Visit(BankAccount bankAccount)
        {
            this.Total += bankAccount.Amount * bankAccount.MonthlyInterest;
        }

        public void Visit(Loan loan)
        {
            this.Total -= loan.MonthlyPayment;
        }
    }
}
