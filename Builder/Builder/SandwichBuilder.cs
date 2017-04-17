namespace Builder
{
    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    public sealed class SandwichBuilder : Builder
    {
        public override void PrepareBread()
        {
            this.Sandwich.BreadType = BreadType.Dark;
            this.Sandwich.IsToasted = true;
        }

        public override void ApplyMeatAndCheese()
        {
            this.Sandwich.CheeseType = CheeseType.Swiss;
        }
    }
}
