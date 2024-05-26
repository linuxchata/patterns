namespace Builder
{
    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    public sealed class SandwichBuilder : Builder
    {
        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.Dark;
            Sandwich.IsToasted = true;
        }

        public override void ApplyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Swiss;
        }
    }
}
