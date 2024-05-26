using System.Collections.Generic;

namespace Observer.Traditional
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class AbstractSubject
    {
        private readonly List<AbstractObserver> _observers = new List<AbstractObserver>();

        public void Register(AbstractObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unregister(AbstractObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
