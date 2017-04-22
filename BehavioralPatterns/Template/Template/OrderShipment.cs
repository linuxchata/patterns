using System;

namespace Template
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class OrderShipment
    {
        public string Address { get; set; }

        public string Label { get; set; }

        /// <summary>
        /// The "Template method"
        /// </summary>
        public void Ship()
        {
            this.VerifyShippingData();
            this.GetShppingLabelFromCarrier();
            this.PrintLabel();
        }

        protected virtual void VerifyShippingData()
        {
            if (string.IsNullOrEmpty(this.Address))
            {
                throw new ArgumentNullException("Address", "Address cannot be null");
            }

            Console.WriteLine("--> Address has been verified");
        }

        protected abstract void GetShppingLabelFromCarrier();

        protected virtual void PrintLabel()
        {
            Console.WriteLine(this.Label);
            Console.WriteLine("--> Label has been print");
        }
    }
}
