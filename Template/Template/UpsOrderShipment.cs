using System;

namespace Template
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class UpsOrderShipment : OrderShipment
    {
        public UpsOrderShipment(string address)
        {
            this.Address = address;
        }

        protected override void GetShppingLabelFromCarrier()
        {
            this.Label = string.Format("UPS:[{0}]", this.Address);
            Console.WriteLine("--> Label has been defined");
        }
    }
}
