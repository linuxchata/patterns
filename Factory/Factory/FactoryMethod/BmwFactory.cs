namespace Factory.FactoryMethod
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new Bmw();
        }
    }
}
