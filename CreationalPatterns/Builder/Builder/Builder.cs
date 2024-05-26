namespace Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class Builder
    {
        protected Sandwich Sandwich;

        public Sandwich GetSandwich()
        {
            return Sandwich;
        }

        public void Create()
        {
            Sandwich = new Sandwich();
        }

        public abstract void PrepareBread();

        public abstract void ApplyMeatAndCheese();
    }
}
