using System;

namespace Builder
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }

        public CheeseType CheeseType { get; set; }

        public bool IsToasted { get; set; }

        public void Display()
        {
            Console.WriteLine("{0}: {1}", "BreadType", this.BreadType);
            Console.WriteLine("{0}: {1}", "CheeseType", this.CheeseType);
            Console.WriteLine("{0}: {1}", "IsToasted", this.IsToasted);
        }
    }
}
