namespace OverdriveEngine
{
    /// <summary>
    /// A tile in a tilemap.
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// The symbol written in the map to spawn the tile.
        /// </summary>
        public string Symbol;
        /// <summary>
        /// The object to spawn.
        /// </summary>
        public Object2D Object;
        /// <summary>
        /// Is this a player?
        /// </summary>
        public bool IsPlayer;

        /// <summary>
        /// Constructs a tile.
        /// </summary>
        /// <param name="Symbol"></param>
        /// <param name="Object"></param>
        /// <param name="IsPlayer"></param>
        public Tile(string Symbol, Object2D Object, bool IsPlayer = false)
        {
            this.Symbol = Symbol;
            this.Object = Object;
            this.IsPlayer = IsPlayer;
        }
    }
}
