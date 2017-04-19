namespace Flyweight
{
    /// <summary>
    /// The 'Flyweight' interface
    /// </summary>
    public interface ITile
    {
        // Extrinsic states
        void Draw(int x, int y, int height, int width);
    }
}
