namespace LazyLoading.ValueHolder
{
    public interface IValueLoader<out T>
    {
        T Load();
    }
}
