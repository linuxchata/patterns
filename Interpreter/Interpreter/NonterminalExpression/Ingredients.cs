using System.Collections.Generic;
using Interpreter.TerminalExpression;

namespace Interpreter.NonterminalExpression
{
    /// <summary>
    /// A 'NonTerminalExpression' class
    /// </summary>
    public sealed class Ingredients : IExpression
    {
        /// <summary>
        /// Maintains instance variables of type IExpression for each of the symbols R1 through Rn.
        /// </summary>
        private readonly List<IExpression> ingredients;

        public Ingredients(List<IExpression> ingredients)
        {
            this.ingredients = ingredients;
        }

        /// <summary>
        /// Implements an Interpret operation for nonterminal symbols in the grammar.
        /// Interpret typically calls itself recursively on the variables representing R1 through Rn.
        /// </summary>
        /// <param name="context"></param>
        public void Interpret(Context context)
        {
            foreach (var ingredient in this.ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}
