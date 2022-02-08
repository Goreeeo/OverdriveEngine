using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverdriveEngine
{
    /// <summary>
    /// A one-dimensional vector with a set range.
    /// </summary>
    public class Axis
    {
        private float Min, Max;

        private float _value;

        /// <summary>
        /// A read only field containing the current value of the Axis.
        /// </summary>
        public float Value { get { return _value; } }

        /// <summary>
        /// Constructs an axis with a default value and the range.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public Axis(float value, float min, float max)
        {
            _value = value;
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float Set(float value)
        {
            if (value >= Min && value <= Max)
            {
                _value = value;
            }
            return _value;
        }

        /// <summary>
        /// Adds on top of the value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float Add(float value)
        {
            if (value >= Min && value <= Max)
            {
                _value += value;
            }
            return _value;
        }

        /// <summary>
        /// Subtracts from the value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float Remove(float value)
        {
            if (value >= Min && value <= Max)
            {
                _value -= value;
            }
            return _value;
        }
    }
}
