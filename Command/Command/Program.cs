using System;
using System.Collections.Generic;

namespace Command
{
    public class Program
    {
        public static void Main()
        {
            var availableCommands = GetAvailableCommands();

            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                PrintUsage(availableCommands);
                Console.ReadKey();
                return;
            }

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
