using System;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Ensure a class has only one instance and provide a global point of access to it.
    /// http://csharpindepth.com/articles/general/singleton.aspx
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Singleton");
            var simpleSingleton = Singleton.Instance;
            Console.WriteLine(simpleSingleton.GetHashCode());
            Console.WriteLine(Singleton.Instance.GetHashCode());
            Console.WriteLine(Singleton.Instance.GetHashCode());
            Console.WriteLine(Singleton.Instance.GetHashCode());
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
