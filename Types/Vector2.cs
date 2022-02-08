using System.Drawing;

namespace OverdriveEngine
{
    /// <summary>
    /// An object containing two floats an X and a Y float.
    /// </summary>
    public class Vector2
    {
        /// <summary>
        /// X of the Vector2.
        /// </summary>
        public float X { get; set; }
        /// <summary>
        /// Y of the Vector2.
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Constructs an empty Vector2.
        /// </summary>
        public Vector2()
        {
            X = Zero().X;
            Y = Zero().Y;
        }

        /// <summary>
        /// Constructs a Vector2 with the values X and Y.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Vector2(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        /// <summary>
        /// Returns a Vector2 with the values 0, 0.
        /// </summary>
        /// <returns></returns>
        public static Vector2 Zero() => new Vector2(0, 0);

        /// <summary>
        /// Returns a Vector2 with the values 1, 1.
        /// </summary>
        /// <returns></returns>
        public static Vector2 One() => new Vector2(1, 1);

        /// <summary>
        /// Converts the Vector into a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"[VECTOR2] X : {X} | Y : {Y}";

        /// <summary>
        /// Inverts a Vector2.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector2 operator - (Vector2 v) => new Vector2(-v.X, -v.Y);
        /// <summary>
        /// Adds two Vector2s by adding their X and Y values together.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 operator + (Vector2 x, Vector2 y) => new Vector2(x.X + y.X, x.Y + y.Y);
        /// <summary>
        /// Adds a Vector2 and a float by adding both of the Vector2s values to the float.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Vector2 operator + (Vector2 v, float f) => new Vector2(v.X + f, v.Y + f);
        /// <summary>
        /// Subtracts two Vector2s by subtracting their X and Y values with each others.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 operator - (Vector2 x, Vector2 y) => new Vector2(x.X - y.X, x.Y - y.Y);
        /// <summary>
        /// Subtracts a Vector2 and a float by subtracting both of the Vector2s values with the float.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Vector2 operator - (Vector2 v, float f) => new Vector2(v.X - f, v.Y - f);
        /// <summary>
        /// Multiplys two Vector2s by multiplying their X and Y values together.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 operator * (Vector2 x, Vector2 y) => new Vector2(x.X * y.X, x.Y * y.Y);
        /// <summary>
        /// Multiplies a Vector2 and a float by multiplying both values of the Vector2 with the float.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Vector2 operator * (Vector2 v, float f) => new Vector2(v.X * f, v.Y * f);
        /// <summary>
        /// Divides two Vectors by dividing their X and Y values with each others.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 operator / (Vector2 x, Vector2 y) => new Vector2(x.X / y.X, x.Y / y.Y);
        /// <summary>
        /// Divides a Vector2 with a float by dividing both of the Vcetor2s values with the float.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Vector2 operator / (Vector2 v, float f) => new Vector2(v.X / f, v.Y / f);
        /// <summary>
        /// Convers a Vector2 to a point.
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Point(Vector2 v) => new Point((int)v.X, (int)v.Y);
        /// <summary>
        /// Converts a Vector2 to a Vector2Int.
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Vector2Int(Vector2 v) => new Vector2Int((int)v.X, (int)v.Y);
    }
}
