using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
