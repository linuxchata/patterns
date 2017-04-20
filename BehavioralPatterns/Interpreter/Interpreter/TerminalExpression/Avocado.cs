namespace Interpreter.TerminalExpression
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// </summary>
    public sealed class Avocado : Ingredient
    {
        /// <summary>
        /// Implements an Interpret operation associated with terminal symbols in the grammar.
        /// </summary>
        public override void Interpret(Context context)
        {
            context.Output += " - Avocado - ";
        }
    }
}
