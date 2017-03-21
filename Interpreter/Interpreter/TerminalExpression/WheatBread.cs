namespace Interpreter.TerminalExpression
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// </summary>
    public class WheatBread : Bread
    {
        public override void Interpret(Context context)
        {
            context.Output += " Wheat Bread ";
        }
    }
}
