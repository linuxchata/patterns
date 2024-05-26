using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public sealed class AnotherTreeIterator<T> : IEnumerator<T>
    {
        private TreeWithIterator<T> _current;

        private readonly TreeWithIterator<T> _tree;

        private readonly Queue<IEnumerator<TreeWithIterator<T>>> _queue;

        public AnotherTreeIterator(TreeWithIterator<T> tree)
        {
            _tree = tree;
            _queue = new Queue<IEnumerator<TreeWithIterator<T>>>();
        }

        public T Current
        {
            get
            {
                return _current.Value;
            }
        }

        public void Dispose()
        {
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                Reset();
                _current = _tree;
                _queue.Enqueue(_current.GetChildren().GetEnumerator());
                return true;
            }
            while (_queue.Count > 0)
            {
                var enumerator = _queue.Peek();
                if (enumerator.MoveNext())
                {
                    _current = enumerator.Current;
                    _queue.Enqueue(_current.GetChildren().GetEnumerator());
                    return true;
                }
                _queue.Dequeue();
            }
            return false;
        }

        public void Reset()
        {
        }
    }
}
