using System;

namespace Factory
{
    /// <summary>
    /// A 'ConcreteProductA' class
    /// </summary>
    public class Bmw : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Running BMW Economy");
        }

        public void TurnOff()
        {
            Console.WriteLine("Stopping BMW Economy");
        }
    }
}
