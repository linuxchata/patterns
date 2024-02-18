namespace Adapter.SimpleAdapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
