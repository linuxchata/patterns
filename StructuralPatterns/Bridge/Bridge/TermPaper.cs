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
            Console.WriteLine(_formatter.Format("Class", Class));
            Console.WriteLine(_formatter.Format("Student", Student));
            Console.WriteLine(_formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}
