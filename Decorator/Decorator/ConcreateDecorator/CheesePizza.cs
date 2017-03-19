using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreateDecorator
{
    public sealed class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza)
            : base(pizza)
        {
        }

        public override string Description
        {
            get
            {
                return "Cheese";
            }
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", base.Pizza.GetDescription(), this.Description);
        }

        public override decimal CalculateCost()
        {
            return base.CalculateCost() + 5;
        }
    }
}
