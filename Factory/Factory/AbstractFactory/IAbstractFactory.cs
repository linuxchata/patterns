namespace Factory.AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' interface
    /// </summary>
    public interface IAbstractFactory
    {
        IAuto CreateEconomyCar();

        IAuto CreateSportCar();
    }
}
