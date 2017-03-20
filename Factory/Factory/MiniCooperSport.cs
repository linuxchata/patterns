using System;

namespace Factory
{
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
