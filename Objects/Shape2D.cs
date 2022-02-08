using OverdriveEngine.Core;

namespace OverdriveEngine
{
    /// <summary>
    /// A simple rectangular shape.
    /// </summary>
    public class Shape2D : Object2D
    {
        /// <summary>
        /// The color of the shape.
        /// </summary>
        public System.Drawing.Color ShapeColor = System.Drawing.Color.White;

        /// <summary>
        /// Constructs a shape using a position and a scale.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Scale"></param>
        /// <param name="Tag"></param>
        /// <param name="ShapeColor"></param>
        public Shape2D(Vector2 Position, Vector2 Scale, string Tag, System.Drawing.Color? ShapeColor = null) : base(Position, Scale, Tag)
        {
            if (ShapeColor != null)
            {
                this.ShapeColor = (System.Drawing.Color)ShapeColor;
            }
            else
            {
                this.ShapeColor = System.Drawing.Color.White;
            }

            EngineCore.Register(this);
        }

        /// <summary>
        /// Constructs a shape using a transform.
        /// </summary>
        /// <param name="Transform"></param>
        /// <param name="Tag"></param>
        /// <param name="ShapeColor"></param>
        public Shape2D(Transform Transform, string Tag, System.Drawing.Color? ShapeColor = null) : base(Transform, Tag)
        {
            if (ShapeColor != null)
            {
                this.ShapeColor = (System.Drawing.Color)ShapeColor;
            }
            else
            {
                this.ShapeColor = System.Drawing.Color.White;
            }

            EngineCore.Register(this);
        }
    }
}
