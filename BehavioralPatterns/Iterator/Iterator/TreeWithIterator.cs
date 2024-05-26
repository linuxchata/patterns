using System.Collections.Generic;

namespace Iterator
{
    public sealed class TreeWithIterator<T> : IEnumerable<T>
    {
        public TreeWithIterator()
        {
        }

        public TreeWithIterator(T value)
        {
            Value = value;
        }

        public TreeWithIterator<T> LeftNode { get; set; }

        public TreeWithIterator<T> RightNode { get; set; }

        public T Value { get; set; }

        public void Add(T value)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new TreeIterator<T>(this);
            //return new AnotherTreeIterator<T>(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public IEnumerable<TreeWithIterator<T>> GetChildren()
        {
            if (LeftNode != null)
            {
                yield return LeftNode;
            }
            if (RightNode != null)
            {
                yield return RightNode;
            }

            yield break;
        }
    }
}
