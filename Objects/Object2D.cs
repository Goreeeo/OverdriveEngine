using OverdriveEngine.Core;
using System.Collections.Generic;

namespace OverdriveEngine
{
    /// <summary>
    /// A basic object.
    /// </summary>
    public abstract class Object2D
    {
        /// <summary>
        /// All components.
        /// </summary>
        protected List<Component> Components = new List<Component>();
        /// <summary>
        /// The transform.
        /// </summary>
        public Transform Transform = null;
        /// <summary>
        /// The tag.
        /// </summary>
        public string Tag = "";

        /// <summary>
        /// Constructs an Object2D.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Scale"></param>
        /// <param name="Tag"></param>
        public Object2D(Vector2 Position, Vector2 Scale, string Tag)
        {
            Components.Add(new Transform(Position, Scale));
            Transform = GetComponent<Transform>();
            this.Tag = Tag;
        }

        /// <summary>
        /// Constructs an Object2D.
        /// </summary>
        /// <param name="Transform"></param>
        /// <param name="Tag"></param>
        public Object2D(Transform Transform, string Tag)
        {
            this.Transform = Transform;
            Components.Add(Transform);
            this.Tag = Tag;
        }

        /// <summary>
        /// Adds a component to the object.
        /// </summary>
        /// <param name="component"></param>
        public void AddComponent(Component component)
        {
            Components.Add(component);
        }

        /// <summary>
        /// Returns a component based on it's class.
        /// </summary>
        /// <returns></returns>
        public T GetComponent<T>() where T : Component
        {
            foreach (Component _component in Components)
            {
                if (_component is T component)
                {
                    return component;
                }
            }

            return null;
        }

        /// <summary>
        /// Checks if the shape is colliding with another shape.
        /// </summary>
        /// <param name="other">The other shape.</param>
        /// <returns>Boolean</returns>
        public bool IsColliding(Object2D other)
        {
            if (Transform.Position.X < other.Transform.Position.X + other.Transform.Scale.X &&
                Transform.Position.X + Transform.Scale.X > other.Transform.Position.X &&
                Transform.Position.Y < other.Transform.Position.Y + other.Transform.Scale.Y &&
                Transform.Position.Y + Transform.Scale.Y > other.Transform.Position.Y) return true;

            return false;
        }

        /// <summary>
        /// Checks if two Shapes are colliding based on their tags.
        /// </summary>
        /// <param name="tag">The tag of the other shape.</param>
        /// <returns>Shape2D</returns>
        public Object2D IsColliding(string tag)
        {
            foreach (Object2D b in EngineCore.AllObjects)
            {
                if (b.Tag == tag)
                {
                    if (Transform.Position.X < b.Transform.Position.X + b.Transform.Scale.X &&
                        Transform.Position.X + Transform.Scale.X > b.Transform.Position.X &&
                        Transform.Position.Y < b.Transform.Position.Y + b.Transform.Scale.Y &&
                        Transform.Position.Y + Transform.Scale.Y > b.Transform.Position.Y)
                    {
                        return b;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Destroys the shape.
        /// </summary>
        public void Destroy()
        {
            EngineCore.Unregister(this);
        }
    }
}
