using System;

namespace TemplateMethod
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public sealed class UpsOrderShipment : OrderShipment
    {
        public UpsOrderShipment(string address)
        {
            Address = address;
        }

        protected override void GetShippingLabelFromCarrier()
        {
            Label = $"UPS:[{Address}]";
            Console.WriteLine("--> Label has been defined");
        }
    }
}
