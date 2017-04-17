using System;

namespace Factory
{
    /// <summary>
    /// A 'ConcreteProductB' class
    /// </summary>
    public class MiniCooper : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Running Mini Cooper");
        }

        public void TurnOff()
        {
            Console.WriteLine("Stop Mini Cooper");
        }
    }
}
