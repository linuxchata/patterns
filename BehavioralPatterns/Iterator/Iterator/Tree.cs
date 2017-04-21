using System.Collections.Generic;

namespace Iterator
{
    public class Tree<T>
    {
        public Tree()
        {
        }

        public Tree(T value)
        {
            this.Value = value;
        }

        public Tree<T> LeftNode { get; set; }

        public Tree<T> RightNode { get; set; }

        public T Value { get; set; }

        public void Add(T value)
        {
        }

        public List<T> ToList()
        {
            var result = new List<T> { this.Value };

            if (this.LeftNode != null)
            {
                result.AddRange(this.LeftNode.ToList());
            }
            if (this.RightNode != null)
            {
                result.AddRange(this.RightNode.ToList());
            }

            return result;
        }
    }
}
