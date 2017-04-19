using System;

namespace Flyweight
{
    /// <summary>
    /// Use sharing to support large numbers of fine-grained objects efficiently.
    /// </summary>
    public class Program
    {
        private static readonly Random Random = new Random();

        public static void Main(string[] args)
        {
            for (var i = 0; i < 20; i++)
            {
                var tile = TileFactory.GeTile(TileFactory.Ceramic);
                tile.Draw(GetRandom(), GetRandom(), GetRandom(), GetRandom());
            }

            for (var i = 0; i < 20; i++)
            {
                var tile = TileFactory.GeTile(TileFactory.Stone);
                tile.Draw(GetRandom(), GetRandom(), GetRandom(), GetRandom());
            }

            Console.WriteLine("Count is {0}.", CeramicTile.Counter + StoneTile.Counter);

            Console.ReadKey();
        }

        private static int GetRandom()
        {
            return Random.Next(0, 21);
        }
    }
}
