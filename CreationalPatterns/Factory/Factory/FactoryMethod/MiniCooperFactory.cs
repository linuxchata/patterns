namespace Factory.FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public sealed class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            return new MiniCooper();
        }
    }
}
