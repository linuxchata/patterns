namespace Factory.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class MiniCooperAbstractFactory : IAbstractFactory
    {
        public IAuto CreateEconomyCar()
        {
            return new MiniCooper();
        }

        public IAuto CreateSportCar()
        {
            return new MiniCooperSport();
        }
    }
}
