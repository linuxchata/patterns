using System;

namespace Facade
{
    /// <summary>
    /// Provide a unified interface to a set of interfaces in a subsystem.
    /// Façade defines a higher-level interface that makes the subsystem easier to use.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}
