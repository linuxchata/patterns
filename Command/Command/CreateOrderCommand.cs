using System;

namespace Command
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Order was create");
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
