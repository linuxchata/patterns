using System;

namespace Flyweight
{
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    public class CeramicTile : ITile
    {
        public static int Counter = 0;

        // Intrinsic state
        private readonly ConsoleColor consoleColor;

        public CeramicTile()
        {
            consoleColor = ConsoleColor.Blue;

            //this.X = x;
            //this.Y = y;
            //this.Height = height;
            //this.Wight = width;

            ++Counter;
        }

        //public int X { get; set; }

        //public int Y { get; set; }

        //public int Height { get; set; }

        //public int Wight { get; set; }

        // Extrinsic states
        public void Draw(int x, int y, int height, int width)
        {
            Console.ForegroundColor = this.consoleColor;
            Console.WriteLine("Ceramic Tile: {0} {1} ({2} X {3})", x, y, height, width);
            Console.ResetColor();
        }
    }
}
