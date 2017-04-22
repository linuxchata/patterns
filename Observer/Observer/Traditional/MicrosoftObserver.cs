using System;

namespace Observer.Traditional
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public sealed class MicrosoftObserver : AbstractObserver
    {
        private readonly StockTickerSubject subject;

        public MicrosoftObserver(StockTickerSubject subject)
        {
            this.subject = subject;
            subject.Register(this);
        }

        public override void Update()
        {
            if (subject.Stock.Name == "MSFT")
            {
                Console.WriteLine("{0} stock are at {1}$", this.subject.Stock.Name, this.subject.Stock.Price);
            }
        }
    }
}
