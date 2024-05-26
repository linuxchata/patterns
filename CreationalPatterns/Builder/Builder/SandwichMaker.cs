namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public sealed class SandwichMaker
    {
        private readonly Builder _builder;

        public SandwichMaker(Builder builder)
        {
            _builder = builder;
        }

        public void CreateSandwich()
        {
            _builder.Create();

            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
        }
    }
}
