using System;
using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public static class TileFactory
    {
        public const string Stone = "stone";

        public const string Ceramic = "ceramic";

        private static readonly Dictionary<string, ITile> Tiles = new Dictionary<string, ITile>();

        public static ITile GeTile(string type)
        {
            switch (type)
            {
                case Stone:
                    if (!Tiles.ContainsKey(Stone))
                    {
                        Tiles[Stone] = new StoneTile();
                    }
                    return Tiles[Stone];
                case Ceramic:
                    if (!Tiles.ContainsKey(Ceramic))
                    {
                        Tiles[Ceramic] = new CeramicTile();
                    }
                    return Tiles[Ceramic];
                default:
                    throw new ArgumentException();
            }
        }
    }
}
