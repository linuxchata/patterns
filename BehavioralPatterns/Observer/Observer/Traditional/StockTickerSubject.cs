namespace Observer.Traditional
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public sealed class StockTickerSubject : AbstractSubject
    {
        private Stock stock;

        public Stock Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
                this.Notify();
            }
        }
    }
}
