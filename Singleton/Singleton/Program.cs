using System;
using System.Threading.Tasks;

namespace Singleton
{
    // http://csharpindepth.com/articles/general/singleton.aspx
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Singleton");
            var simpleSingleton = Singleton.Instance;
            Console.WriteLine(simpleSingleton.GetHashCode());
            Console.WriteLine(simpleSingleton.GetHashCode());
            Console.WriteLine(simpleSingleton.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("Singleton Lock");
            Parallel.For(
                0,
                25,
                new ParallelOptions
                {
                    MaxDegreeOfParallelism = 25
                },
                i =>
                {
                    var singletonLock = SingletonLock.Instance;
                    Console.WriteLine(singletonLock.GetHashCode());
                });
            Console.WriteLine();

            Console.WriteLine("Lazy Singleton");
            Parallel.For(
                0,
                25,
                new ParallelOptions
                {
                    MaxDegreeOfParallelism = 25
                },
                i =>
                {
                    var singletonLazy = SingletonLazy.Instance;
                    Console.WriteLine(singletonLazy.GetHashCode());
                });
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
