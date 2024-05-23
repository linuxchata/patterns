namespace Multiton
{
    public class Printer
    {
        private static readonly Dictionary<Subsystem, Printer> Instances = [];

        private Printer()
        {
        }

        public static Printer Get(Subsystem subsystem)
        {
            if (Instances.TryGetValue(subsystem, out var printer))
            {
                return printer;
            }

            var instance = new Printer();
            Instances[subsystem] = instance;
            return instance;
        }
    }
}
