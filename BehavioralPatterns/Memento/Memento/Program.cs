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

            var prespectMemory = new PrespectMemory();
            prespectMemory.SaveState(prospect.SaveMemento());

            prospect.Name = "Leo Welch";
            prespectMemory.SaveState(prospect.SaveMemento());
            prospect.PrintState();

            prospect.Phone = "(310) 209-7111";
            prespectMemory.SaveState(prospect.SaveMemento());
            prospect.PrintState();

            prospect.Budget = 1000000.0m;
            prespectMemory.SaveState(prospect.SaveMemento());
            prospect.PrintState();

            Console.WriteLine("Restoring the states...");
            Console.WriteLine();

            prospect.RestoreMemento(prespectMemory.Undo());
            prospect.PrintState();
            prospect.RestoreMemento(prespectMemory.Undo());
            prospect.PrintState();
            prospect.RestoreMemento(prespectMemory.Undo());
            prospect.PrintState();

            Console.ReadKey();
        }
    }
}
