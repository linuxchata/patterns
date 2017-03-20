namespace Factory.FactoryMethod
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new MiniCooper();
        }
    }
}
