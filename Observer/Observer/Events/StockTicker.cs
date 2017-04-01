using System;

namespace Observer.Events
{
    public class StockTicker
    {
        private Stock stock;

        public event EventHandler<StockChangeEventArgs> StockChange;

        public Stock Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
                this.OnStockChanged();
            }
        }

        private void OnStockChanged()
        {
            if (StockChange != null)
            {
                StockChange(this, new StockChangeEventArgs(this.stock));
            }
        }
    }
}
