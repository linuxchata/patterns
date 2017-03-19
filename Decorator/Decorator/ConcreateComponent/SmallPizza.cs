using Decorator.Component;

namespace Decorator.ConcreateComponent
{
    public class SmallPizza : Pizza
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
            return this.Description;
        }

        public override decimal CalculateCost()
        {
            return 32;
        }
    }
}
