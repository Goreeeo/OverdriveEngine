using System.Windows.Forms;

namespace OverdriveEngine
{
    /// <summary>
    /// An Axis used by the input manager.
    /// </summary>
    public class InputAxis : Axis
    {
        /// <summary>
        /// The Key to trigger the end of the axis.
        /// </summary>
        public Keys? Low, High;

        /// <summary>
        /// Constructs an Input Axis.
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public InputAxis(Keys? low, Keys? high) : base(0, -1, 1)
        {
            Low = low;
            High = high;
        }
    }
}
