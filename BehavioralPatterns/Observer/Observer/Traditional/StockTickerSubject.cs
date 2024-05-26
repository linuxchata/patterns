namespace Observer.Traditional
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public sealed class StockTickerSubject : AbstractSubject
    {
        private Stock _stock;

        public Stock Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                Notify();
            }
        }
    }
}
