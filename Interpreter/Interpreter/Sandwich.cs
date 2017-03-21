using System;
using Interpreter.NonterminalExpression;
using Interpreter.TerminalExpression;

namespace Interpreter
{
    /// <summary>
    /// Cient class
    /// </summary>
    public class Sandwich : IExpression
    {
        private readonly Bread topBread;
        private readonly Ingredients ingredients;
        private readonly Bread bottomBread;

        public Sandwich(Bread topBread, Ingredients ingredients, Bread bottomBread)
        {
            this.topBread = topBread;
            this.ingredients = ingredients;
            this.bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            this.topBread.Interpret(context);
            context.Output += "|";
            context.Output += " << ";
            this.ingredients.Interpret(context);
            context.Output += " >> ";
            context.Output += "|";
            this.bottomBread.Interpret(context);
            context.Output += "|";

            Console.WriteLine(context.Output);
        }
    }
}
