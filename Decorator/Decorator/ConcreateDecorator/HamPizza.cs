﻿using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreateDecorator
{
    public class HamPizza : PizzaDecorator
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
            return string.Format("{0}, {1}", base.Pizza.GetDescription(), this.Description);
        }

        public override decimal CalculateCost()
        {
            return base.Pizza.CalculateCost() + 7;
        }
    }
}
