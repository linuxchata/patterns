using Decorator.Component;

namespace Decorator.ConcreateComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public sealed class SmallPizza : Pizza
    {
        public override string Description
        {
            get
            {
                return "Small Pizza";
            }
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return 32;
        }
    }
}
