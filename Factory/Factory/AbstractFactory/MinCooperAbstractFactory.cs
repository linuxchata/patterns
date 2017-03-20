namespace Factory.AbstractFactory
{
    public class MinCooperAbstractFactory : IAbstractFactory
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
