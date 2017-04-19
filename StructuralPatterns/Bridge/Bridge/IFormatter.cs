namespace Bridge
{
    /// <summary>
    /// The 'Implementor' interface
    /// </summary>
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
