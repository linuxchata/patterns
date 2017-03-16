using System;
using System.Collections.Generic;

namespace Bridge
{
    public class Faq : Manuscript
    {
        public Faq(IFormatter formatter)
            : base(formatter)
        {
            this.Questions = new Dictionary<string, string>();
        }

        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(this.formatter.Format("Title", this.Title));
            foreach (var q in this.Questions)
            {
                Console.WriteLine(this.formatter.Format(q.Key, q.Value));
            }
            Console.WriteLine();
        }
    }
}
