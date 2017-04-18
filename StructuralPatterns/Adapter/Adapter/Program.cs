using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
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
            var adapter = new StubAdapter();

            var renderer = new DataRenderer(adapter);
            var stringWriter = new StringWriter();
            renderer.Render(stringWriter);
            Console.WriteLine(stringWriter.ToString());

            var connection = new SqlCeConnection(@"Data Source=db.sdf");
            var command = new SqlCeCommand("SELECT * FROM Pattern", connection);
            var dataAdapter = new SqlCeDataAdapter(command);

            renderer = new DataRenderer(dataAdapter);
            stringWriter = new StringWriter();
            renderer.Render(stringWriter);
            Console.WriteLine(stringWriter.ToString());

            var list = new List<Pattern>
            {
                new Pattern { Id = 1, Name = "Strategy" },
                new Pattern { Id = 2, Name = "MVC" }
            };
            var patternRendered = new PatternRenderer();
            Console.WriteLine(patternRendered.PatternsList(list));

            Console.WriteLine("Simple adapter pattern");
            Target target = new Target();
            target.Request();

            var adaptee = new Adapter.SimpleAdapter.Adaptee();
            target = new Adapter.SimpleAdapter.Adapter(adaptee);
            target.Request();

            Console.ReadKey();
        }
    }
}
