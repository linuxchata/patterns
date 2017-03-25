using System.Collections.Generic;

namespace Iterator
{
    public class TreeWithIterator<T> : IEnumerable<T>
    {
        public TreeWithIterator()
        {
        }

        public TreeWithIterator(T value)
        {
            this.Value = value;
        }

        public TreeWithIterator<T> LeftNode { get; set; }

        public TreeWithIterator<T> RightNode { get; set; }

        public T Value { get; set; }

        public void Add(T value)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return new TreeIterator<T>(this);
            return new AnotherTreeIterator<T>(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public IEnumerable<TreeWithIterator<T>> GetChildren()
        {
            if (this.LeftNode != null)
            {
                yield return this.LeftNode;
            }
            if (this.RightNode != null)
            {
                yield return this.RightNode;
            }

            yield break;
        }
    }
}
