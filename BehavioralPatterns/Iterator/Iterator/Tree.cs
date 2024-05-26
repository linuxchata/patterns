using System.Collections.Generic;

namespace Iterator
{
    public sealed class Tree<T>
    {
        public Tree()
        {
        }

        public Tree(T value)
        {
            Value = value;
        }

        public Tree<T> LeftNode { get; set; }

        public Tree<T> RightNode { get; set; }

        public T Value { get; set; }

        public void Add(T value)
        {
        }

        public List<T> ToList()
        {
            var result = new List<T> { Value };

            if (LeftNode != null)
            {
                result.AddRange(LeftNode.ToList());
            }
            if (RightNode != null)
            {
                result.AddRange(RightNode.ToList());
            }

            return result;
        }
    }
}
