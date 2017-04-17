using System;

namespace Factory.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory' class
    /// </summary>
    public class BmwAbstractFactory : IAbstractFactory
    {
        public IAuto CreateEconomyCar()
        {
            return new Bmw();
        }

        public IAuto CreateSportCar()
        {
            return new BmwI7();
        }
    }
}
