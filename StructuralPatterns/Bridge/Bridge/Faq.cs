using System;
using System.Collections.Generic;

namespace Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public sealed class Faq : Manuscript
    {
        public Faq(IFormatter formatter)
            : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Title", Title));
            foreach (var q in Questions)
            {
                Console.WriteLine(_formatter.Format(q.Key, q.Value));
            }
            Console.WriteLine();
        }
    }
}
