using System;

namespace Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public sealed class Book : Manuscript
    {
        public Book(IFormatter formatter)
            : base(formatter)
        {
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine(this.formatter.Format("Title", this.Title));
            Console.WriteLine(this.formatter.Format("Author", this.Author));
            Console.WriteLine(this.formatter.Format("Text", this.Text));
            Console.WriteLine();
        }
    }
}
