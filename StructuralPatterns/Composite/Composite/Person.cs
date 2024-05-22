using System;

namespace Composite
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public sealed class Person : IParty
    {
        public string Name { get; set; }

        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} peaces of GOLD", Name, Gold);
        }
    }
}
