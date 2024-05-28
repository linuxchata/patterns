namespace Memento
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public sealed class Memento
    {
        public Memento(string name, string phone, decimal budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public decimal Budget { get; set; }
    }
}
