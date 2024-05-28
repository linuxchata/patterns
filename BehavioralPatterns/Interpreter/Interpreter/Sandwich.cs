using System;
using Interpreter.NonterminalExpression;
using Interpreter.TerminalExpression;

namespace Interpreter
{
    /// <summary>
    /// Cient class
    /// </summary>
    public sealed class Sandwich : IExpression
    {
        private readonly Bread _topBread;
        private readonly Ingredients _ingredients;
        private readonly Bread _bottomBread;

        public Sandwich(Bread topBread, Ingredients ingredients, Bread bottomBread)
        {
            _topBread = topBread;
            _ingredients = ingredients;
            _bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            _topBread.Interpret(context);
            context.Output += "|";
            context.Output += " << ";
            _ingredients.Interpret(context);
            context.Output += " >> ";
            context.Output += "|";
            _bottomBread.Interpret(context);
            context.Output += "|";

            Console.WriteLine(context.Output);
        }
    }
}
