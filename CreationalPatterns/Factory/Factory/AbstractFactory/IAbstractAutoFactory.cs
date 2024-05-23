namespace Factory.AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' interface
    /// </summary>
    public interface IAbstractAutoFactory
    {
        IAuto CreateEconomyAuto();

        IAuto CreateSportAuto();
    }
}
