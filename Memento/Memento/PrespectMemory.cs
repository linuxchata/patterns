using System.Collections.Generic;

namespace Memento
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class PrespectMemory
    {
        private readonly Stack<Memento> mementoes;

        public PrespectMemory()
        {
            this.mementoes = new Stack<Memento>();
        }

        public void SaveState(Memento memento)
        {
            this.mementoes.Push(memento);
        }

        public Memento Undo()
        {
            Memento m = null;
            if (mementoes.Count > 1)
            {
                mementoes.Pop();
                m = mementoes.Peek();
            }
            return m;
        }
    }
}
