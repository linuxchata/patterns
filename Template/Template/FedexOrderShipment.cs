using System;

namespace Template
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class FedexOrderShipment : OrderShipment
    {
        public FedexOrderShipment(string address)
        {
            this.Address = address;
        }

        protected override void GetShppingLabelFromCarrier()
        {
            this.Label = string.Format("FEDEX:|{0}|", this.Address);
            Console.WriteLine("--> Label has been defined");
        }
    }
}
