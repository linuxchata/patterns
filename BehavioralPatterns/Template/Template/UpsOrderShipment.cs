using System;

namespace Template
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public sealed class UpsOrderShipment : OrderShipment
    {
        public UpsOrderShipment(string address)
        {
            this.Address = address;
        }

        protected override void GetShippingLabelFromCarrier()
        {
            this.Label = $"UPS:[{this.Address}]";
            Console.WriteLine("--> Label has been defined");
        }
    }
}
