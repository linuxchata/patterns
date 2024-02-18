using System;
using Adapter.ClassAdapter;
using Adapter.ObjectAdapter;
using Adapter.SimpleAdapter;

namespace Adapter
{
    /// <summary>
    /// Convert the interface of a class into another interface clients expect.
    /// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Simple adapter pattern
            Console.WriteLine("Simple Adapter pattern");
            Target target = new Target();
            target.Request();

            var adaptee = new Adaptee();
            target = new SimpleAdapter.Adapter(adaptee);
            target.Request();

            // Object Adapter (aggregation)
            Console.WriteLine("Object Adapter pattern");
            var objectAdapter = new SoundPlayerObjectAdapter();
            objectAdapter.LoadTrack(string.Empty);
            objectAdapter.PlayTrack();

            // Class Adapter (inheritance)
            Console.WriteLine("Class Adapter pattern");
            var classAdapter = new SoundPlayerClassAdapter();
            classAdapter.LoadTrack(string.Empty);
            classAdapter.PlayTrack();

            Console.ReadKey();
        }
    }
}
