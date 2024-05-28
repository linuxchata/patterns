using System.Collections.Generic;

namespace Memento
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public sealed class PrespectMemory
    {
        private readonly Stack<Memento> _mementoes;

        public PrespectMemory()
        {
            _mementoes = new Stack<Memento>();
        }

        public void SaveState(Memento memento)
        {
            _mementoes.Push(memento);
        }

        public Memento Undo()
        {
            Memento m = null;
            if (_mementoes.Count > 1)
            {
                _mementoes.Pop();
                m = _mementoes.Peek();
            }
            return m;
        }
    }
}
