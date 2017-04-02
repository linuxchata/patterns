namespace Visitor
{
    /// <summary>
    /// The 'Element' interface
    /// </summary>
    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }
}
