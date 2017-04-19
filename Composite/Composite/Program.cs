using System;

namespace Composite
{
    /// <summary>
    /// Compose objects into tree structures to represent part-whole hierarchies.
    /// Composite lets clients treat individual objects and compositions of objects uniformly.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var goldForKill = 1103;

            var p1 = new Person { Name = "John" };
            var p2 = new Person { Name = "Mary" };
            var p3 = new Person { Name = "Emily" };
            var p4 = new Person { Name = "Sophia" };
            var p5 = new Person { Name = "Brain" };
            var p6 = new Person { Name = "Bob" };
            var p7 = new Person { Name = "Sam" };

            var testers = new Group { Name = "Testers", Members = { p5, p6, p7 } };
            var devs = new Group { Name = "Developers", Members = { p3, p4, testers } };

            var parties = new Group { Members = { devs, p1, p2 } };

            parties.Gold += goldForKill;
            parties.Stats();

            Console.ReadKey();
        }
    }
}
