using System;

namespace Memento
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public sealed class SalesProspect
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public decimal Budget { get; set; }

        public Memento SaveMemento()
        {
            return new Memento(Name, Phone, Budget);
        }

        public void RestoreMemento(Memento memento)
        {
            if (memento != null)
            {
                Name = memento.Name;
                Phone = memento.Phone;
                Budget = memento.Budget;
            }
        }

        public void PrintState()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Budget: " + Budget);
            Console.WriteLine();
        }
    }
}
