namespace OverdriveEngine
{
    /// <summary>
    /// An audio file playable with an AudioPlayer.
    /// </summary>
    public class Audio
    {
        /// <summary>
        /// The name of the audio in the game.
        /// </summary>
        public string Name;
        /// <summary>
        /// The name (and path) of the audio in the DataPath/Sounds folder.
        /// </summary>
        public string Directory;

        /// <summary>
        /// Makes an audio ready for use with an AudioPlayer.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="directory"></param>
        public Audio(string name, string directory)
        {
            Name = name;
            Directory = directory;
        }
    }
}
