using System;

namespace Factory
{
    public class BmwI7 : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Running BMWI7 Sport");
        }

        public void TurnOff()
        {
            Console.WriteLine("Stop BMWI7 Sport");
        }
    }
}
