namespace Interpreter.TerminalExpression
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// </summary>
    public class Avocado : Ingredient
    {
        public override void Interpret(Context context)
        {
            context.Output += " - Avocado - ";
        }
    }
}
