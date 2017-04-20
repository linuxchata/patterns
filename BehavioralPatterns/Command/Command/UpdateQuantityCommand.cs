using System;

namespace Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public void Execute()
        {
            const int OldQuantity = 5;
            Console.WriteLine("Database was updated from {0} to {1} value for quantity", OldQuantity, this.NewQuantity);
        }

        public string CommandName
        {
            get
            {
                return "UpdateOrder";
            }
        }

        public ICommand MakeCommand(string[] args)
        {
            return new UpdateQuantityCommand { NewQuantity = int.Parse(args[1]) };
        }
    }
}
