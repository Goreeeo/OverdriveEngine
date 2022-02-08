using System;
using System.Collections.Generic;
using System.Media;

namespace OverdriveEngine
{
    /// <summary>
    /// An AudioPlayer to play sounds.
    /// </summary>
    public class AudioPlayer
    {
        private SoundPlayer Player = new SoundPlayer();
        private Dictionary<string, Audio> Audios = new Dictionary<string, Audio>();

        /// <summary>
        /// Constructs an audio player and adds the music.
        /// </summary>
        /// <param name="audios"></param>
        public AudioPlayer(params Audio[] audios)
        {
            foreach (Audio audio in audios)
            {
                Audios.Add(audio.Name, audio);
            }
        }

        /// <summary>
        /// Plays a sound/music.
        /// </summary>
        /// <param name="name"></param>
        public void PlayAudio(string name)
        {
            if (Audios.ContainsKey(name))
            {
                Player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + $"{Constants.DataPath}\\Sounds\\{Audios[name].Directory}.wav";
                Player.Play();
            }
            else
            {
                Log.Error("Could not find sound " + AppDomain.CurrentDomain.BaseDirectory + $"{Constants.DataPath}\\Sounds\\{Audios[name].Directory}.wav");
            }
        }
    }
}
