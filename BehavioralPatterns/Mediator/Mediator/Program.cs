using System;

namespace Mediator
{
    /// <summary>
    /// Define an object that encapsulates how a set of objects interact.
    /// Mediator promotes loose coupling by keeping objects from referring
    /// to each other explicitly, and it lets you vary their interaction independently.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var atc = new YyyControl();
            var airbus321 = new Airbus321("RN1", atc);
            var embraer190 = new Embraer190("RN2", atc);
            var boeing737 = new Boeing737("RN3", atc);

            Console.WriteLine();

            airbus321.Altitude += 100;
            embraer190.Altitude += 200;

            Console.ReadKey();
        }
    }
}
