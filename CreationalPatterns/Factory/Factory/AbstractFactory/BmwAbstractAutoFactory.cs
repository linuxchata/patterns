namespace Factory.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public sealed class BmwAbstractAutoFactory : IAbstractAutoFactory
    {
        public IAuto CreateEconomyAuto()
        {
            return new Bmw();
        }

        public IAuto CreateSportAuto()
        {
            return new BmwI7();
        }
    }
}
