using System;

namespace Template
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class OrderShipment
    {
        protected string Address { get; set; }

        protected string Label { get; set; }

        /// <summary>
        /// The "Template method"
        /// </summary>
        public void Ship()
        {
            this.VerifyShippingData();
            this.GetShippingLabelFromCarrier();
            this.PrintLabel();
        }

        protected virtual void VerifyShippingData()
        {
            if (string.IsNullOrEmpty(this.Address))
            {
                throw new ArgumentNullException(nameof(this.Address), "Address cannot be null");
            }

            Console.WriteLine($"--> Address is {this.Address}");
            Console.WriteLine("--> Address has been verified");
        }

        protected abstract void GetShippingLabelFromCarrier();

        protected virtual void PrintLabel()
        {
            Console.WriteLine($"--> Label is {this.Label}");
            Console.WriteLine("--> Label has been printed");
        }
    }
}
