using System;

namespace Factory
{
    public class Bmw : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Running BMW Economy");
        }

        public void TurnOff()
        {
            Console.WriteLine("Stop BMW Economy");
        }
    }
}
