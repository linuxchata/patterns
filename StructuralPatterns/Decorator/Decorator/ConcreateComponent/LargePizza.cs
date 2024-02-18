using Decorator.Component;

namespace Decorator.ConcreateComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public sealed class LargePizza : Pizza
    {
        public override string Description
        {
            get
            {
                return "Large Pizza";
            }
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return 30;
        }
    }
}
