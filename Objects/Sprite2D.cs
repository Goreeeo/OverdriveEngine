using OverdriveEngine.Core;
using System.Drawing;

namespace OverdriveEngine
{
    /// <summary>
    /// A Sprite which renders in the game.
    /// </summary>
    public class Sprite2D : Object2D
    {
        /// <summary>
        /// The directory of the sprite within the datapath/sprites folder.
        /// </summary>
        public string Directory = "";
        /// <summary>
        /// The sprite itself.
        /// </summary>
        public Bitmap Sprite = null;

        /// <summary>
        /// Constructs a sprite using a raw position and scale.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Scale"></param>
        /// <param name="Directory"></param>
        /// <param name="Tag"></param>
        public Sprite2D(Vector2 Position, Vector2 Scale, string Directory, string Tag) : base(Position, Scale, Tag)
        {
            this.Directory = Directory;

            Image tmp = Image.FromFile($"{Constants.DataPath}/Sprites/{Directory}.png");
            Sprite = new Bitmap(tmp, (int)Transform.Scale.X, (int)Transform.Scale.Y);

            EngineCore.Register(this);
        }

        /// <summary>
        /// Constructs a sprite using a transform.
        /// </summary>
        /// <param name="Transform"></param>
        /// <param name="Directory"></param>
        /// <param name="Tag"></param>
        public Sprite2D(Transform Transform, string Directory, string Tag) : base(Transform, Tag)
        {
            this.Directory = Directory;

            Image tmp = Image.FromFile($"{Constants.DataPath}/Sprites/{Directory}.png");
            Sprite = new Bitmap(tmp, (int)this.Transform.Scale.X, (int)this.Transform.Scale.Y);

            EngineCore.Register(this);
        }

        /// <summary>
        /// Constructs a sprite using a raw position and scale.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Scale"></param>
        /// <param name="Sprite"></param>
        /// <param name="Tag"></param>
        public Sprite2D(Vector2 Position, Vector2 Scale, Sprite2D Sprite, string Tag) : base(Position, Scale, Tag)
        {
            this.Sprite = Sprite.Sprite;

            EngineCore.Register(this);
        }

        /// <summary>
        /// Constructs a sprite using a transform.
        /// </summary>
        /// <param name="Transform"></param>
        /// <param name="Sprite"></param>
        /// <param name="Tag"></param>
        public Sprite2D(Transform Transform, Sprite2D Sprite, string Tag) : base(Transform, Tag)
        {
            this.Sprite = Sprite.Sprite;

            EngineCore.Register(this);
        }

        /// <summary>
        /// Updates the sprite to a new one.
        /// </summary>
        /// <param name="Sprite"></param>
        public void UpdateImage(Sprite2D Sprite)
        {
            this.Sprite = Sprite.Sprite;
        }
    }
}
