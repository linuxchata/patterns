using System;

namespace Observer.Events
{
    public class StockTicker
    {
        private Stock _stock;

        public event EventHandler<StockChangeEventArgs> StockChange;

        public Stock Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                OnStockChanged();
            }
        }

        private void OnStockChanged()
        {
            if (StockChange != null)
            {
                StockChange(this, new StockChangeEventArgs(_stock));
            }
        }
    }
}
