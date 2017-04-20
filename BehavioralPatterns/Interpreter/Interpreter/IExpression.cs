namespace Interpreter
{
    /// <summary>
    /// Abstract Expression
    /// Interface for executing an operation
    /// </summary>
    public interface IExpression
    {
        void Interpret(Context context);
    }
}
