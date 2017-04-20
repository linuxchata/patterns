namespace Command
{
    public interface ICommandFactory
    {
        string CommandName { get; }

        ICommand MakeCommand(string[] args);
    }
}
