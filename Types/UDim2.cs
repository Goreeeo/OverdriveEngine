namespace OverdriveEngine
{
    /// <summary>
    /// Contains two Vector2s.
    /// </summary>
    public class UDim2
    {
        /// <summary>
        /// The position Vector.
        /// </summary>
        public Vector2 Position;
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
        public Vector2 Scale;
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
        public UDim2(Vector2 Position, Vector2 Scale)
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
        public UDim2(float X, float Y, float W, float H)
        {
            Position = new Vector2(X, Y);
            Scale = new Vector2(W, H);
        }

        /// <summary>
        /// Converts the UDim2 to a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[UDIM2INT] Position: [X : {X} | Y : {Y}], Scale: [W : {W} | Y : {Y}]";
        }

        /// <summary>
        /// Returns a UDim2 with all values being 0.
        /// </summary>
        /// <returns></returns>
        public static UDim2 Zero() => new UDim2(0, 0, 0, 0);

        /// <summary>
        /// Returns a UDim2 with all values being 1.
        /// </summary>
        /// <returns></returns>
        public static UDim2 One() => new UDim2(1, 1, 1, 1);

        /// <summary>
        /// Converts a UDim2 to a UDim2Int.
        /// </summary>
        /// <param name="u"></param>
        public static implicit operator UDim2Int(UDim2 u) => new UDim2Int((int)u.X, (int)u.Y, (int)u.W, (int)u.H);
    }
}
