namespace Interpreter.TerminalExpression
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// </summary>
    public class Tomato : Ingredient
    {
        public override void Interpret(Context context)
        {
            context.Output += " - Tomato - ";
        }
    }
}
