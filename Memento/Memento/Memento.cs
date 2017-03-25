namespace Memento
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        public Memento(string name, string phone, decimal budget)
        {
            this.Name = name;
            this.Phone = phone;
            this.Budget = budget;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public decimal Budget { get; set; }
    }
}
