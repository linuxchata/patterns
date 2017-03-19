using Decorator.Component;

namespace Decorator.ConcreateComponent
{
    public class MediumPizza : Pizza
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
            return this.Description;
        }

        public override decimal CalculateCost()
        {
            return 25;
        }
    }
}
