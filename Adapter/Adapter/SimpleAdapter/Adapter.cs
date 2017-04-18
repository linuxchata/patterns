namespace Adapter.SimpleAdapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : Target
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public override void Request()
        {
            this.adaptee.SpecificRequest();
        }
    }
}
