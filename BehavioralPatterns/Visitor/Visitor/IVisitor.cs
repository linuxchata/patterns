namespace Visitor
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(RealEstate realEstate);

        void Visit(BankAccount bankAccount);

        void Visit(Loan loan);
    }
}
