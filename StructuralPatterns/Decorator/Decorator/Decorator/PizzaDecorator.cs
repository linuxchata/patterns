using Decorator.Component;

namespace Decorator.Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class PizzaDecorator : Pizza
    {
        protected readonly Pizza Pizza;

        protected PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string Description
        {
            get
            {
                return Pizza.Description;
            }
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return Pizza.CalculateCost();
        }
    }
}
