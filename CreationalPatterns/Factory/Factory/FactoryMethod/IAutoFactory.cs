namespace Factory.FactoryMethod
{
    /// <summary>
    /// The 'Creator' interface
    /// </summary>
    public interface IAutoFactory
    {
        IAuto CreateAuto();
    }
}
