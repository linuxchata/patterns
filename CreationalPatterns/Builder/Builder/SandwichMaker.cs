﻿namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public sealed class SandwichMaker
    {
        private readonly Builder builder;

        public SandwichMaker(Builder builder)
        {
            this.builder = builder;
        }

        public void CreateSandwich()
        {
            this.builder.Create();

            this.builder.PrepareBread();
            this.builder.ApplyMeatAndCheese();
        }
    }
}
