using Decorator.Component;

namespace Decorator.ConcreateComponent
{
    public class LargePizza : Pizza
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
            return this.Description;
        }

        public override decimal CalculateCost()
        {
            return 30;
        }
    }
}
