namespace OverdriveEngine
{
    /// <summary>
    /// A UDim2 consisting of ints.
    /// </summary>
    public class UDim2Int
    {
        /// <summary>
        /// The position Vector.
        /// </summary>
        public Vector2Int Position;
        /// <summary>
        /// The X of the position Vector.
        /// </summary>
        public float X => Position.X;
        /// <summary>
        /// The Y of the position vector.
        /// </summary>
        public float Y => Position.Y;
        /// <summary>
        /// The scale Vector.
        /// </summary>
        public Vector2Int Scale;
        /// <summary>
        /// The width of the scale vector.
        /// </summary>
        public float W => Scale.X;
        /// <summary>
        /// The height of the scale vector.
        /// </summary>
        public float H => Scale.Y;

        /// <summary>
        /// Constructs a UDim2 using two Vectors.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Scale"></param>
        public UDim2Int(Vector2Int Position, Vector2Int Scale)
        {
            this.Position = Position;
            this.Scale = Scale;
        }

        /// <summary>
        /// Constructs a UDim2 using four floats.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="W"></param>
        /// <param name="H"></param>
        public UDim2Int(int X, int Y, int W, int H)
        {
            Position = new Vector2Int(X, Y);
            Scale = new Vector2Int(W, H);
        }

        /// <summary>
        /// Converts the UDim2 to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[UDIM2] Position: [X : {X} | Y : {Y}], Scale: [W : {W} | Y : {Y}]";
        }

        /// <summary>
        /// Returns a UDim2 with all values being 0.
        /// </summary>
        /// <returns></returns>
        public static UDim2Int Zero() => new UDim2Int(0, 0, 0, 0);

        /// <summary>
        /// Returns a UDim2 with all values being 1.
        /// </summary>
        /// <returns></returns>
        public static UDim2Int One() => new UDim2Int(1, 1, 1, 1);

        /// <summary>
        /// Converts a UDim2Int to a UDim2.
        /// </summary>
        /// <param name="u"></param>
        public static implicit operator UDim2(UDim2Int u) => new UDim2(u.X, u.Y, u.W, u.H);
    }
}
