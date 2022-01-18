using System;

namespace Template
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public sealed class FedexOrderShipment : OrderShipment
    {
        public FedexOrderShipment(string address)
        {
            this.Address = address;
        }

        protected override void GetShippingLabelFromCarrier()
        {
            this.Label = $"FEDEX:|{this.Address}|";
            Console.WriteLine("--> Label has been defined");
        }
    }
}
