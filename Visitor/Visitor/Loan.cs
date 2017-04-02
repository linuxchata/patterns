namespace Visitor
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public sealed class Loan : IAsset
    {
        public decimal Owned { get; set; }

        public decimal MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
