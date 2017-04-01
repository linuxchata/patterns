using System.Collections.Generic;

namespace Observer.Traditional
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public class AbstractSubject
    {
        private readonly List<AbstractObserver> observers = new List<AbstractObserver>();

        public void Register(AbstractObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unregister(AbstractObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
