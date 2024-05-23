using System;

namespace Singleton
{
    public sealed class SingletonLazy2
    {
        private static readonly Lazy<SingletonLazy2> Lazy = new Lazy<SingletonLazy2>(() => new SingletonLazy2());

        private SingletonLazy2()
        {
        }

        public static SingletonLazy2 GetInstance()
        {
            return Lazy.Value;
        }
    }
}
