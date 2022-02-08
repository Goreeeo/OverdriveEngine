namespace OverdriveEngine
{
    /// <summary>
    /// Contains the location of an object.
    /// </summary>
    public class Transform : Component
    {
        /// <summary>
        /// The position of the object.
        /// </summary>
        public Vector2 Position;
        /// <summary>
        /// The scale of the object.
        /// </summary>
        public Vector2 Scale;

        /// <summary>
        /// Constructs a new Transform taking in the position and scale.
        /// </summary>
        /// <param name="Position">The position of the object.</param>
        /// <param name="Scale">The scale of the object.</param>
        public Transform(Vector2 Position, Vector2 Scale) : base()
        {
            this.Position = Position;
            this.Scale = Scale;
        }
    }
}
