using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OverdriveEngine
{
    /// <summary>
    /// A tilemap to map sprites to a grid.
    /// </summary>
    public class Tilemap
    {
        /// <summary>
        /// The map to align the sprites to.
        /// </summary>
        public string[,] CoreTileMap =
        {

        };

        /// <summary>
        /// The amount of each object on startup.
        /// </summary>
        public Dictionary<string, int> Amounts = new Dictionary<string, int>();

        /// <summary>
        /// The player object.
        /// </summary>
        public Object2D Player = null;

        /// <summary>
        /// Constructs a tilemap.
        /// </summary>
        /// <param name="Map"></param>
        /// <param name="tiles"></param>
        public Tilemap(string[,] Map, params Tile[] tiles)
        {
            if (Map != null)
            {
                this.CoreTileMap = Map;
            }

            Thread mappingThread = new Thread(() => GenerateMap(tiles));
            mappingThread.Start();
        }

        /// <summary>
        /// Generates the final map.
        /// </summary>
        /// <param name="tiles"></param>
        public void GenerateMap(params Tile[] tiles)
        {
            for (int i = 0; i < CoreTileMap.GetLength(1); i++)
            {
                for (int j = 0; j < CoreTileMap.GetLength(0); j++)
                {
                    foreach (Tile tile in tiles)
                    {
                        if (CoreTileMap[j, i] == tile.Symbol)
                        {
                            Object2D current = null;

                            if (tile.Object is Shape2D)
                            {
                                Shape2D temp = (Shape2D)tile.Object;
                                current = new Shape2D(new Vector2(i * 50 + tile.Object.Transform.Scale.X / 2, j * 50 + tile.Object.Transform.Scale.Y / 2), tile.Object.Transform.Scale, tile.Object.Tag, ShapeColor: temp.ShapeColor);
                            }

                            if (tile.Object is Sprite2D)
                            {
                                Sprite2D temp = (Sprite2D)tile.Object;
                                current = new Sprite2D(new Vector2(i * 50 + tile.Object.Transform.Scale.X / 2, j * 50 + tile.Object.Transform.Scale.Y / 2), tile.Object.Transform.Scale, temp.Directory, tile.Object.Tag);
                            }

                            if (tile.IsPlayer)
                            {
                                Player = current;
                            }

                            if (Amounts.Keys.Contains(tile.Symbol))
                            {
                                Amounts[tile.Symbol] += 1;
                            }
                            else
                            {
                                Amounts.Add(tile.Symbol, 1);
                            }
                        }
                    }
                }
            }

            foreach (Tile tile in tiles)
            {
                tile.Object.Destroy();
            }
        }
    }
}
