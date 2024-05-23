namespace Factory.FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public sealed class BmwFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            return new Bmw();
        }
    }
}
