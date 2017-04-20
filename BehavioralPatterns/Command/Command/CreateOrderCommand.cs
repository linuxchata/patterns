using System;

namespace Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Order was created");
        }

        public string CommandName
        {
            get
            {
                return "CreateOrder";
            }
        }

        public ICommand MakeCommand(string[] args)
        {
            return new CreateOrderCommand();
        }
    }
}
