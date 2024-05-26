using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public sealed class TreeIterator<T> : IEnumerator<T>
    {
        private TreeWithIterator<T> _current;

        private readonly TreeWithIterator<T> _tree;

        private readonly Stack<TreeWithIterator<T>> _crumb;

        public TreeIterator(TreeWithIterator<T> tree)
        {
            _tree = tree;
            _crumb = new Stack<TreeWithIterator<T>>();
        }

        public T Current
        {
            get
            {
                return _current.Value;
            }
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                Reset();
                _current = _tree;
                return true;
            }
            if (_current.LeftNode != null)
            {
                return TraverseLeft();
            }
            if (_current.RightNode != null)
            {
                return TraverseRight();
            }

            return TraverseUpAndRight();
        }

        public void Reset()
        {
            _current = null;
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

        private bool TraverseLeft()
        {
            _crumb.Push(_current);
            _current = _current.LeftNode;
            return true;
        }

        private bool TraverseRight()
        {
            _crumb.Push(_current);
            _current = _current.RightNode;
            return true;
        }

        private bool TraverseUpAndRight()
        {
            if (_crumb.Count > 0)
            {
                _current = _crumb.Pop();
                if (_current.RightNode != null)
                {
                    _current = _current.RightNode;
                    return true;
                }
            }

            return false;
        }
    }
}
