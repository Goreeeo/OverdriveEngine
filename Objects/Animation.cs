using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OverdriveEngine
{
    /// <summary>
    /// A playable animation.
    /// </summary>
    public class Animation
    {
        private Sprite2D target;

        /// <summary>
        /// The individual frames of the animation.
        /// </summary>
        public List<Sprite2D> Frames;
        /// <summary>
        /// The offsets between frames.
        /// </summary>
        public List<int> Offsets;

        /// <summary>
        /// Is the animation looping?
        /// </summary>
        public bool IsLooping;

        /// <summary>
        /// Constructs an animation.
        /// </summary>
        /// <param name="Frames"></param>
        /// <param name="Offsets"></param>
        /// <param name="IsLooping"></param>
        public Animation(List<Sprite2D> Frames, List<int> Offsets, bool IsLooping = false)
        {
            this.Frames = Frames;
            this.Offsets = Offsets;
            this.IsLooping = IsLooping;

            while (this.Offsets.Count < this.Frames.Count)
            {
                this.Offsets.Add(0);
            }
        }

        /// <summary>
        /// Plays an animation.
        /// </summary>
        /// <param name="sprite"></param>
        /// <param name="animationThread"></param>
        public void Play(Sprite2D sprite, Thread animationThread)
        {
            target = sprite;
            animationThread = new Thread(() => PlayAnimation(animationThread));
            animationThread.Start();
        }

        private void PlayAnimation(Thread animationThread)
        {
            for (int i = 0; i < Frames.Count; i++)
            {
                target.UpdateImage(Frames[i]);

                Thread.Sleep(Offsets[i]);
            }

            if (IsLooping)
            {
                Play(target, animationThread);
            }
        }
    }
}
