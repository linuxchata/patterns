namespace Builder
{
    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    public sealed class ClubSandwichBuilder : Builder
    {
        public override void PrepareBread()
        {
            this.Sandwich.BreadType = BreadType.Wheet;
            this.Sandwich.IsToasted = false;
        }

        public override void ApplyMeatAndCheese()
        {
            this.Sandwich.CheeseType = CheeseType.Holland;
        }
    }
}
