namespace Factory.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAuto CreateEconomyCar();

        IAuto CreateSportCar();
    }
}
