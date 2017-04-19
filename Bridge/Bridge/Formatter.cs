namespace Bridge
{
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    public sealed class Formatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, value);
        }
    }
}
