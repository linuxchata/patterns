using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreateDecorator
{
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    public sealed class HamPizza : PizzaDecorator
    {
        public HamPizza(Pizza pizza) : base(pizza)
        {
        }
        
        public override string Description
        {
            get
            {
                return "Ham";
            }
        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", base.Pizza.GetDescription(), Description);
        }

        public override decimal CalculateCost()
        {
            return base.Pizza.CalculateCost() + 7;
        }
    }
}
