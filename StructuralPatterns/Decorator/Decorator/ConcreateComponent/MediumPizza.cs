using Decorator.Component;

namespace Decorator.ConcreateComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public sealed class MediumPizza : Pizza
    {
        public override string Description
        {
            get
            {
                return "Medium Pizza";
            }
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return 25;
        }
    }
}
