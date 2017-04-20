using System;

namespace Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class NullCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Command cannot be executed");
        }

        public string CommandName
        {
            get
            {
                return "NullCommand";
            }
        }

        public ICommand MakeCommand(string[] args)
        {
            return new NullCommand();
        }
    }
}
