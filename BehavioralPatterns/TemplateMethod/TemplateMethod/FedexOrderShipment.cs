using System;

namespace TemplateMethod
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public sealed class FedexOrderShipment : OrderShipment
    {
        public FedexOrderShipment(string address)
        {
            Address = address;
        }

        protected override void GetShippingLabelFromCarrier()
        {
            Label = $"FEDEX:|{Address}|";
            Console.WriteLine("--> Label has been defined");
        }
    }
}
