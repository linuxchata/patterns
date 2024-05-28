using System;

namespace TemplateMethod
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
            VerifyShippingData();
            GetShippingLabelFromCarrier();
            PrintLabel();
        }

        protected virtual void VerifyShippingData()
        {
            if (string.IsNullOrEmpty(Address))
            {
                throw new ArgumentNullException(nameof(Address), "Address cannot be null");
            }

            Console.WriteLine($"--> Address is {Address}");
            Console.WriteLine("--> Address has been verified");
        }

        protected abstract void GetShippingLabelFromCarrier();

        protected virtual void PrintLabel()
        {
            Console.WriteLine($"--> Label is {Label}");
            Console.WriteLine("--> Label has been printed");
        }
    }
}
