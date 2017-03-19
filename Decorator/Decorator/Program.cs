using System;
using Decorator.Component;
using Decorator.ConcreateComponent;
using Decorator.ConcreateDecorator;

namespace Decorator
{
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
