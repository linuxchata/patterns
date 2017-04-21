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
            var prospect = new SalesProspect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 2500.0m
            };

            prospect.PrintState();

            var m = new PrespectMemory();
            m.SaveState(prospect.SaveMemento());

            prospect.Name = "Leo Welch";
            m.SaveState(prospect.SaveMemento());
            prospect.PrintState();

            prospect.Phone = "(310) 209-7111";
            m.SaveState(prospect.SaveMemento());
            prospect.PrintState();

            prospect.Budget = 1000000.0m;
            m.SaveState(prospect.SaveMemento());
            prospect.PrintState();

            prospect.RestoreMemento(m.Undo());
            prospect.RestoreMemento(m.Undo());
            prospect.RestoreMemento(m.Undo());
            prospect.PrintState();
            
            Console.ReadKey();
        }
    }
}
