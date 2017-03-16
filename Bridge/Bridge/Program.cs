using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Manuscript>();
            var formatter = new ReverseFormatter();

            var faq = new Faq(formatter)
            {
                Title = "Title"
            };
            faq.Questions.Add("Question one", "Answer to question one");
            faq.Questions.Add("Question two", "Answer to question two");
            list.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Title",
                Author = "Author",
                Text = "Text"
            };
            list.Add(book);

            var termPaper = new TermPaper(formatter)
            {
                Class = "Class",
                Student = "John Oliver",
                Text = "Text"
            };
            list.Add(termPaper);

            foreach (var l in list)
            {
                l.Print();
            }

            Console.ReadKey();
        }
    }
}
