namespace Visitor
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public sealed class BankAccount : IAsset
    {
        public decimal Amount { get; set; }

        public decimal MonthlyInterest { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
