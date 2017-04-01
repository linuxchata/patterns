namespace Singleton
{
    public sealed class SingletonLock
    {
        private static SingletonLock instance;

        private static readonly object Sync = new object();

        private SingletonLock()
        {
        }

        public static SingletonLock Instance
        {
            get
            {
                lock (Sync)
                {
                    if (instance == null)
                    {
                        instance = new SingletonLock();
                    }

                    return instance;
                }
            }
        }
    }
}
