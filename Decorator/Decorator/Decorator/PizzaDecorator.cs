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
            this.Pizza = pizza;
        }

        public override string Description
        {
            get
            {
                return this.Pizza.Description;
            }
        }

        public override string GetDescription()
        {
            return this.Description;
        }

        public override decimal CalculateCost()
        {
            return this.Pizza.CalculateCost();
        }
    }
}
