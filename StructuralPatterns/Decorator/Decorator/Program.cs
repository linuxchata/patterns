using System;
using System.IO;
using System.IO.Compression;
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
            // Class Decorator pattern
            Pizza largePizza = new LargePizza();
            largePizza = new HamPizza(largePizza);
            largePizza = new CheesePizza(largePizza);

            Console.WriteLine("{0} costs {1}.", largePizza.GetDescription(), largePizza.CalculateCost());

            // .NET example
            var fileName = "compress.bin";
            var text = "Decorator pattern";
            using (var fileStream = File.Create(fileName))
            {
                using (var deflateStream = new DeflateStream(fileStream, CompressionLevel.Optimal))
                {
                    using (var bufferedStream = new BufferedStream(deflateStream))
                    {
                        using (var textWriter = new StreamWriter(bufferedStream))
                        {
                            textWriter.Write(text + " ");
                        }
                    }
                }
            }

            Console.WriteLine("{0} was created", fileName);

            Console.ReadKey();
        }
    }
}
