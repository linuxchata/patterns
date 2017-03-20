using System;

namespace Factory.AbstractFactory
{
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
