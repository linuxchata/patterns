using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parameterize clients
    /// with different requests, queue or log requests, and support undoable operations.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var availableCommands = GetAvailableCommands();

            PrintUsage(availableCommands);

            Console.WriteLine();
            var input = Console.ReadLine();
            var args = input.Split(' ');

            var commandParser = new CommandParser(availableCommands);
            var command = commandParser.ParseCommand(args);
            command.Execute();

            Console.ReadKey();
        }

        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                new CreateOrderCommand(),
                new UpdateQuantityCommand()
            };
        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Available commands:");

            foreach (var command in availableCommands)
            {
                Console.WriteLine(command.CommandName);
            }
        }
    }
}
