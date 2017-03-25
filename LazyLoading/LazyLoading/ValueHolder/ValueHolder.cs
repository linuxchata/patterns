namespace LazyLoading.ValueHolder
{
    public class ValueHolder<T>
    {
        private T value;

        private readonly IValueLoader<T> loader;

        public ValueHolder(IValueLoader<T> loader)
        {
            this.loader = loader;
        }

        public T Value
        {
            get
            {
                if (value == null)
                {
                    value = this.loader.Load();
                }

                return this.value;
            }
        }
    }
}
