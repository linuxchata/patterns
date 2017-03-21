namespace Interpreter.TerminalExpression
{
    public abstract class Ingredient : IExpression
    {
        public abstract void Interpret(Context context);
    }
}
