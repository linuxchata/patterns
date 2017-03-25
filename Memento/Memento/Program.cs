using System;

namespace Memento
{
    /// <summary>
    /// Without violating encapsulation, capture and externalize an object's
    /// internal state so that the object can be restored to this state later.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var prostect = new SalesProstect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 2500.0m
            };

            prostect.PrintState();

            var m = new PrespectMemory();
            m.SaveState(prostect.SaveMemento());

            prostect.Name = "Leo Welch";
            m.SaveState(prostect.SaveMemento());
            prostect.PrintState();

            prostect.Phone = "(310) 209-7111";
            m.SaveState(prostect.SaveMemento());
            prostect.PrintState();

            prostect.Budget = 1000000.0m;
            m.SaveState(prostect.SaveMemento());
            prostect.PrintState();

            prostect.RestoreMemento(m.Undo());
            prostect.RestoreMemento(m.Undo());
            prostect.RestoreMemento(m.Undo());
            prostect.PrintState();
            
            Console.ReadKey();
        }
    }
}
