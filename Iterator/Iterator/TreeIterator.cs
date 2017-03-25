using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeIterator<T> : IEnumerator<T>
    {
        private TreeWithIterator<T> current;

        private readonly TreeWithIterator<T> tree;

        private readonly Stack<TreeWithIterator<T>> crumb;

        public TreeIterator(TreeWithIterator<T> tree)
        {
            this.tree = tree;
            this.crumb = new Stack<TreeWithIterator<T>>();
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
                Reset();
                this.current = this.tree;
                return true;
            }
            if (this.current.LeftNode != null)
            {
                return TraverseLeft();
            }
            if (this.current.RightNode != null)
            {
                return TraverseRight();
            }

            return TraverseUpAndRight();
        }

        private bool TraverseLeft()
        {
            this.crumb.Push(this.current);
            this.current = this.current.LeftNode;
            return true;
        }

        private bool TraverseRight()
        {
            this.crumb.Push(this.current);
            this.current = this.current.RightNode;
            return true;
        }

        private bool TraverseUpAndRight()
        {
            if (this.crumb.Count > 0)
            {
                this.current = this.crumb.Pop();
                if (this.current.RightNode != null)
                {
                    this.current = this.current.RightNode;
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            this.current = null;
        }
    }
}
