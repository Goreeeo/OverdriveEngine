using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OverdriveEngine
{
    /// <summary>
    /// The manager which contains all things related to Input.
    /// </summary>
    public class InputManager
    {
        private Dictionary<Keys, bool> KeysPressed = new Dictionary<Keys, bool>();
        private Dictionary<Keys, bool> KeysDown = new Dictionary<Keys, bool>();
        private Dictionary<Keys, bool> KeysUp = new Dictionary<Keys, bool>();

        private Dictionary<string, InputAxis> Axes = new Dictionary<string, InputAxis>()
        {
            {"Horizontal", new InputAxis(Keys.A, Keys.D)},
            {"Vertical", new InputAxis(Keys.W, Keys.S)}
        };

        /// <summary>
        /// Instantiates a new InputManager.
        /// </summary>
        public InputManager()
        {
            foreach (Keys key in (Keys[])Enum.GetValues(typeof(Keys)))
            {
                if (!KeysPressed.ContainsKey(key))
                {
                    KeysPressed.Add(key, false);
                }

                if (!KeysDown.ContainsKey(key))
                {
                    KeysDown.Add(key, false);
                }

                if (!KeysUp.ContainsKey(key))
                {
                    KeysUp.Add(key, true);
                }
            }
        }

        /// <summary>
        /// Gets called every frame to update the input manager.
        /// </summary>
        public void Update()
        {
            foreach (InputAxis axis in Axes.Values)
            {
                if (axis.Low != null && axis.High != null)
                {
                    if (GetKey((Keys)axis.Low) && GetKey((Keys)axis.High))
                    {
                        axis.Set(0);
                    }
                    else if (GetKey((Keys)axis.Low) && !GetKey((Keys)axis.High))
                    {
                        axis.Set(-1);
                    }
                    else if (!GetKey((Keys)axis.Low) && GetKey((Keys)axis.High))
                    {
                        axis.Set(1);
                    }
                    else
                    {
                        axis.Set(0);
                    }
                }
                else if (axis.Low != null && axis.High == null)
                {
                    if (GetKey((Keys)axis.Low))
                    {
                        axis.Set(-1);
                    }
                    else
                    {
                        axis.Set(0);
                    }
                }
                else if (axis.High != null && axis.Low == null)
                {
                    if (GetKey((Keys)axis.High))
                    {
                        axis.Set(1);
                    }
                    else
                    {
                        axis.Set(0);
                    }
                }
                else
                {
                    axis.Set(1);
                }
            }
        }


        /// <summary>
        /// Checks if a key is being held.
        /// </summary>
        /// <param name="key">The keycode of the key you want to check.</param>
        /// <returns></returns>
        public bool GetKey(Keys key)
        {
            if (KeysPressed[key]) return true;
            else return false;
        }

        /// <summary>
        /// Checks if a key is pressed once.
        /// </summary>
        /// <param name="key">The keycode of the key you want to check.</param>
        /// <returns></returns>
        public bool GetKeyDown(Keys key)
        {
            if (KeysPressed[key] && !KeysDown[key])
            {
                KeysDown[key] = true;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Checks if a key is released.
        /// </summary>
        /// <param name="key">The keycode of the key you want to check.</param>
        /// <returns></returns>
        public bool GetKeyUp(Keys key)
        {
            if (!KeysPressed[key] && !KeysUp[key])
            {
                KeysUp[key] = true;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Gets triggered when any key is released.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AnyKeyUp(object sender, KeyEventArgs e)
        {
            KeysDown[e.KeyCode] = false;
            KeysPressed[e.KeyCode] = false;
            OnKeyUp(e);
        }

        /// <summary>
        /// Gets triggered when any key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AnyKeyDown(object sender, KeyEventArgs e)
        {
            KeysUp[e.KeyCode] = false;
            KeysPressed[e.KeyCode] = true;
            OnKeyDown(e);
        }

        /// <summary>
        /// Returns the axis itself based on its name.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public InputAxis GetAxisRaw(string axis)
        {
            if (Axes[axis] != null)
            {
                return Axes[axis];
            }
            else
            {
                Log.Warn($"[INPUT] Axis {axis} not found.");
                return null;
            }
        }

        /// <summary>
        /// Returns the value of an axis based on its name.
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public float GetAxis(string axis)
        {
            if (Axes[axis] != null)
            {
                return Axes[axis].Value;
            }
            else
            {
                Log.Warn($"[INPUT] Axis {axis} not found.");
                return 0;
            }
        }

        /// <summary>
        /// Sets or creates an Input Axis.
        /// </summary>
        /// <param name="axisName"></param>
        /// <param name="axis"></param>
        public void SetAxis(string axisName, InputAxis axis)
        {
            if (Axes.ContainsKey(axisName))
            {
                Axes[axisName] = axis;
            }
            else
            {
                Axes.Add(axisName, axis);
            }
        }

        /// <summary>
        /// Triggers when a key is pressed, gives access to the raw data of the key.
        /// </summary>
        /// <param name="e">The raw data of the key press.</param>
        public virtual void OnKeyDown(KeyEventArgs e)
        {

        }

        /// <summary>
        /// Triggers when a key is released, gives access to the raw data of the key.
        /// </summary>
        /// <param name="e">The raw data of the key press.</param>
        public virtual void OnKeyUp(KeyEventArgs e)
        {

        }
    }
}
