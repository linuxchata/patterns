namespace Factory.FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new Bmw();
        }
    }
}
