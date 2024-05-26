namespace Builder
{
    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    public sealed class ClubSandwichBuilder : Builder
    {
        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.Wheet;
            Sandwich.IsToasted = false;
        }

        public override void ApplyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Holland;
        }
    }
}
