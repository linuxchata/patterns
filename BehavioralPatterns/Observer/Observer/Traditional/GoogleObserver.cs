using System;

namespace Observer.Traditional
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public sealed class GoogleObserver : AbstractObserver
    {
        private readonly StockTickerSubject _subject;

        public GoogleObserver(StockTickerSubject subject)
        {
            _subject = subject;
            subject.Register(this);
        }

        public override void Update()
        {
            if (_subject.Stock.Name == "GOOG")
            {
                Console.WriteLine("{0} stock are at {1}$", _subject.Stock.Name, _subject.Stock.Price);
            }
        }
    }
}
