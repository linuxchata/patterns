using System;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new SandwichBuilder();
            var maker = new SandwichMaker(builder);
            maker.CreateSandwich();
            var sandwich = builder.GetSandwich();
            sandwich.Display();

            Console.WriteLine();

            var builder2 = new ClubSandwichBuilder();
            var maker2 = new SandwichMaker(builder2);
            maker2.CreateSandwich();
            var sandwich2 = builder2.GetSandwich();
            sandwich2.Display();

            Console.ReadKey();
        }
    }
}
