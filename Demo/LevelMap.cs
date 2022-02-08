namespace OverdriveEngine.Demos
{
    /// <summary>
    /// A map for the demo level.
    /// </summary>
    public class LevelMap : Tilemap
    {
        /// <summary>
        /// The map.
        /// </summary>
        /// <value></value>
        public static string[,] Map =
        {
            {".",".",".",".",".",".",".",".",".",".","."},
            {".",".",".",".",".",".",".",".",".",".","."},
            {".",".",".",".",".",".",".",".",".",".","."},
            {".",".",".",".",".",".",".",".",".",".","."},
            {".",".",".",".",".","p",".",".",".",".","."},
            {".",".",".",".",".",".",".",".",".",".","."},
            {".",".",".",".",".",".",".",".",".",".","."},
            {"g","g","g","g","g","g","g","g","g","g","g"},
        };

        /// <summary>
        /// Constructs the level map.
        /// </summary>
        /// <returns></returns>
        public LevelMap() : base(Map,
            new Tile("g", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Ground", ShapeColor: System.Drawing.Color.Red)),
            new Tile("p", new Shape2D(Vector2.Zero(), new Vector2(50, 50), "Player", ShapeColor: System.Drawing.Color.Aqua), true)
        )
        {

        }
    }
}
