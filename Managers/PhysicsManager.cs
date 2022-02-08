namespace OverdriveEngine
{
    /// <summary>
    /// The manager which contains all things related to physics.
    /// </summary>
    public class PhysicsManager
    {
        /// <summary>
        /// Instantiates a new Physics Manager.
        /// </summary>
        public PhysicsManager()
        {

        }

        /// <summary>
        /// Checks if two objects are colliding.
        /// </summary>
        /// <param name="a">The first sprite.</param>
        /// <param name="b">The second sprite.</param>
        /// <returns></returns>
        public bool IsColliding(Object2D a, Object2D b)
        {
            if (a.Transform.Position.X < b.Transform.Position.X + b.Transform.Scale.X &&
                a.Transform.Position.X + a.Transform.Scale.X > b.Transform.Position.X &&
                a.Transform.Position.Y < b.Transform.Position.Y + b.Transform.Scale.Y &&
                a.Transform.Position.Y + a.Transform.Scale.Y > b.Transform.Position.Y) return true;

            return false;
        }
    }
}
