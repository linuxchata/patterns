using System;

namespace Flyweight
{
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    public sealed class CeramicTile : ITile
    {
        public static int Counter = 0;

        // Intrinsic state
        private readonly ConsoleColor _consoleColor;

        public CeramicTile()
        {
            _consoleColor = ConsoleColor.Blue;

            // X = x;
            // Y = y;
            // Height = height;
            // Wight = width;

            ++Counter;
        }

        // public int X { get; set; }

        // public int Y { get; set; }

        // public int Height { get; set; }

        // public int Wight { get; set; }

        // Extrinsic states
        public void Draw(int x, int y, int height, int width)
        {
            Console.ForegroundColor = _consoleColor;
            Console.WriteLine("Ceramic Tile: {0} {1} ({2} X {3})", x, y, height, width);
            Console.ResetColor();
        }
    }
}
