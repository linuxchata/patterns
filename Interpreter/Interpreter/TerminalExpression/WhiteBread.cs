namespace Interpreter.TerminalExpression
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// </summary>
    public class WhiteBread : Bread
    {
        public override void Interpret(Context context)
        {
            context.Output += " White Bread ";
        }
    }
}
