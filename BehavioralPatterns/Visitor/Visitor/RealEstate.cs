namespace Visitor
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public sealed class RealEstate : IAsset
    {
        public decimal EstimatedValue { get; set; }

        public decimal MonthlyRent { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
