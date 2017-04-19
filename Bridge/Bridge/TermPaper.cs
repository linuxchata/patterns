using System;

namespace Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public sealed class TermPaper : Manuscript
    {
        public TermPaper(IFormatter formatter)
            : base(formatter)
        {
        }

        public string Class { get; set; }

        public string Student { get; set; }

        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine(this.formatter.Format("Class", this.Class));
            Console.WriteLine(this.formatter.Format("Student", this.Student));
            Console.WriteLine(this.formatter.Format("Text", this.Text));
            Console.WriteLine();
        }
    }
}
