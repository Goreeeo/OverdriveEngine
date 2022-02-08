using System.Threading;
using System.Windows.Forms;

namespace OverdriveEngine
{
    /// <summary>
    /// Allows multiple forms to be open.
    /// </summary>
    public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        /// <summary>
        /// Constructs a MultiFormContext.
        /// </summary>
        /// <param name="forms"></param>
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }
    }
}
