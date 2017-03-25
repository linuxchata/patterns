using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AnotherTreeIterator<T> : IEnumerator<T>
    {
        private TreeWithIterator<T> current;

        private readonly TreeWithIterator<T> tree;

        private readonly Queue<IEnumerator<TreeWithIterator<T>>> queue;

        public AnotherTreeIterator(TreeWithIterator<T> tree)
        {
            this.tree = tree;
            this.queue = new Queue<IEnumerator<TreeWithIterator<T>>>();
        }

        public T Current
        {
            get
            {
                return this.current.Value;
            }
        }

        public void Dispose()
        {
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public bool MoveNext()
        {
            if (this.current == null)
            {
                this.Reset();
                this.current = this.tree;
                this.queue.Enqueue(this.current.GetChildren().GetEnumerator());
                return true;
            }
            while (this.queue.Count > 0)
            {
                var enumerator = this.queue.Peek();
                if (enumerator.MoveNext())
                {
                    this.current = enumerator.Current;
                    this.queue.Enqueue(this.current.GetChildren().GetEnumerator());
                    return true;
                }
                this.queue.Dequeue();
            }
            return false;
        }

        public void Reset()
        {
        }
    }
}
