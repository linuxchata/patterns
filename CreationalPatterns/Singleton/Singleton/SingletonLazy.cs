namespace Singleton
{
    public sealed class SingletonLazy
    {
        private SingletonLazy()
        {
        }

        public static SingletonLazy Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly SingletonLazy instance = new SingletonLazy();
        }
    }
}
