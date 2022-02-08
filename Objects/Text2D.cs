using OverdriveEngine.Core;
using System.Drawing;

namespace OverdriveEngine
{
    /// <summary>
    /// A text object.
    /// </summary>
    public class Text2D : Object2D
    {
        /// <summary>
        /// The text of the text object.
        /// </summary>
        public string Text = "";
        /// <summary>
        /// The font of the text object.
        /// </summary>
        public Font Font = new Font(FontFamily.GenericSansSerif, 100, FontStyle.Regular, GraphicsUnit.Pixel);
        /// <summary>
        /// The brush of the text object.
        /// </summary>
        public Brush Brush = new SolidBrush(Color.Black);

        /// <summary>
        /// Constructs a text using a position and a scale.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Size"></param>
        /// <param name="Tag"></param>
        /// <param name="Text"></param>
        /// <param name="Font"></param>
        /// <param name="Style"></param>
        /// <param name="TextColor"></param>
        public Text2D(Vector2 Position, int Size, string Tag, string Text, FontFamily Font = null, FontStyle Style = FontStyle.Regular, Color? TextColor = null) : base(Position, new Vector2(1, 1), Tag)
        {
            this.Text = Text;

            if (Font != null)
            {
                this.Font = new Font(Font, Size, Style, GraphicsUnit.Pixel);
            }
            else
            {
                this.Font = new Font(FontFamily.GenericSansSerif, Size, Style, GraphicsUnit.Pixel);
            }

            if (TextColor != null)
            {
                Brush = new SolidBrush((Color)TextColor);
            }
            else
            {
                Brush = new SolidBrush(Color.Black);
            }

            EngineCore.Register(this);
        }
    }
}
