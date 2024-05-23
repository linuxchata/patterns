namespace Factory.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public sealed class MiniCooperAbstractAutoFactory : IAbstractAutoFactory
    {
        public IAuto CreateEconomyAuto()
        {
            return new MiniCooper();
        }

        public IAuto CreateSportAuto()
        {
            return new MiniCooperSport();
        }
    }
}
