using System;
using Decorator.Component;
using Decorator.ConcreateComponent;
using Decorator.ConcreateDecorator;

namespace Decorator
{
    /// <summary>
    /// Attach additional responsibilities to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new HamPizza(largePizza);
            largePizza = new CheesePizza(largePizza);

            Console.WriteLine("{0} costs {1}.", largePizza.GetDescription(), largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
