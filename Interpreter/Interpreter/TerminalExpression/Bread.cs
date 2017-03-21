namespace Interpreter.TerminalExpression
{
    public abstract class Bread : IExpression
    {
        public abstract void Interpret(Context context);
    }
}
