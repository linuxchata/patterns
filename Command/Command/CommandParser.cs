using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        public ICommand ParseCommand(string[] args)
        {
            var requestedName = args[0];

            var command = this.availableCommands.FirstOrDefault(c => string.Equals(c.CommandName, requestedName, StringComparison.OrdinalIgnoreCase))
                ?? new NullCommand();

            return command.MakeCommand(args);
        }
    }
}
