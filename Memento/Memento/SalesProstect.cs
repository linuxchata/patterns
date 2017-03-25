using System;

namespace Memento
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class SalesProstect
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public decimal Budget { get; set; }

        public Memento SaveMemento()
        {
            return new Memento(this.Name, this.Phone, this.Budget);
        }

        public void RestoreMemento(Memento memento)
        {
            if (memento != null)
            {
                this.Name = memento.Name;
                this.Phone = memento.Phone;
                this.Budget = memento.Budget;
            }
        }

        public void PrintState()
        {
            Console.WriteLine("Name " + this.Name);
            Console.WriteLine("Phone " + this.Phone);
            Console.WriteLine("Budget " + this.Budget);
            Console.WriteLine();
        }
    }
}
