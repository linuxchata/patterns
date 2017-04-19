using System.Linq;

namespace Bridge
{
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    public sealed class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, new string(value.Reverse().ToArray()));
        }
    }
}
