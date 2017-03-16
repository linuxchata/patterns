
namespace Builder
{
    public abstract class Builder
    {
        protected Sandwich Sandwich;

        public Sandwich GetSandwich()
        {
            return this.Sandwich;
        }

        public void Create()
        {
            this.Sandwich = new Sandwich();
        }

        public abstract void PrepareBread();

        public abstract void ApplyMeatAndCheese();
    }
}
