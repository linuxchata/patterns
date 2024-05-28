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
            Total += realEstate.MonthlyRent;
        }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount * bankAccount.MonthlyInterest;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.MonthlyPayment;
        }
    }
}
