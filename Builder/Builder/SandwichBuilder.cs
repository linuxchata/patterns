namespace Builder
{
    public class SandwichBuilder : Builder
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
