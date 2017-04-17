using System;

namespace Factory
{
    /// <summary>
    /// A 'ConcreteProductB' class
    /// </summary>
    public class MiniCooperSport : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Running Mini Cooper S");
        }

        public void TurnOff()
        {
            Console.WriteLine("Stop Mini Cooper S");
        }
    }
}
