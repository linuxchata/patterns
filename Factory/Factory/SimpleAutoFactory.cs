using System;
using System.Collections.Generic;

namespace Factory
{
    public class SimpleAutoFactory
    {
        private readonly Dictionary<string, Type> autos = new Dictionary<string, Type>
        {
            { "bmw", typeof(Bmw) },
            { "minicooper", typeof(MiniCooper) }
        };

        public IAuto CreateAuto(string name)
        {
            var car = autos[name];

            return Activator.CreateInstance(car) as IAuto;
        }
    }
}
