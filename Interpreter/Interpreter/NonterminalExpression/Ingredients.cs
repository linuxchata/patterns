using System.Collections.Generic;
using Interpreter.TerminalExpression;

namespace Interpreter.NonterminalExpression
{
    public class Ingredients : IExpression
    {
        private readonly List<Ingredient> ingredients;

        public Ingredients(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach (var ingredient in this.ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}
