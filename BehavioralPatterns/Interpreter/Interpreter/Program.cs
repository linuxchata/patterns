using System;
using System.Collections.Generic;
using Interpreter.NonterminalExpression;
using Interpreter.TerminalExpression;

namespace Interpreter
{
    /// <summary>
    /// Given a language, define a representation for its grammar along with an
    /// interpreter that uses the representation to interpret sentences in the language.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context();

            var ingredients = new List<IExpression> { new Avocado(), new Tomato(), new Avocado() };
            var topBread = new WheatBread();
            var bottomBread = new WhiteBread();
            var sandwich = new Sandwich(topBread, new Ingredients(ingredients), bottomBread);

            sandwich.Interpret(context);

            Console.ReadKey();
        }
    }
}
