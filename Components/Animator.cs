using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OverdriveEngine
{
    /// <summary>
    /// Holds the animations for a sprite.
    /// </summary>
    public class Animator : Component
    {
        private List<Animation> Animations = new List<Animation>();

        private Thread animationThread = null;

        /// <summary>
        /// Adds an animation to the List.
        /// </summary>
        /// <param name="animation"></param>
        public void AddAnimation(Animation animation)
        {
            Animations.Add(animation);
        }

        /// <summary>
        /// Plays an animation.
        /// </summary>
        /// <param name="animation"></param>
        /// <param name="sprite"></param>
        public void PlayAnimation(Animation animation, Sprite2D sprite)
        {
            if (animationThread != null)
            {
                animationThread.Abort();
            }
            animation.Play(sprite, animationThread);
        }
    }
}
