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

            var builder2 = new SandwichBuilder();
            var maker2 = new SandwichMaker(builder2);
            maker2.CreateSandwich();
            var sandwich2 = builder.GetSandwich();

            sandwich2.Display();

            Console.ReadKey();
        }
    }
}
