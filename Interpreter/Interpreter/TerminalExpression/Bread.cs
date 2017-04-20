namespace Interpreter.TerminalExpression
{
    /// <summary>
    /// A 'TerminalExpression' abstract class
    /// </summary>
    public abstract class Bread : IExpression
    {
        /// <summary>
        /// Implements an Interpret operation associated with terminal symbols in the grammar.
        /// </summary>
        public abstract void Interpret(Context context);
    }
}
