using System.Collections.Generic;

namespace OverdriveEngine.Core
{
    /// <summary>
    /// The core of the engine. (Files hidden from the user.)
    /// </summary>
    public class EngineCore
    {
        /// <summary>
        /// A collection of all objects.
        /// </summary>
        public static List<Object2D> AllObjects = new List<Object2D>();

        /// <summary>
        /// Decides if the game starts up in Debug Mode or not.
        /// </summary>
        public static bool DebugMode = false;

        /// <summary>
        /// Registers a simple object.
        /// </summary>
        /// <param name="object2d"></param>
        public static void Register(Object2D object2d)
        {
            AllObjects.Add(object2d);
        }

        /// <summary>
        /// Unregisters a simple object.
        /// </summary>
        /// <param name="object2D"></param>
        public static void Unregister(Object2D object2D)
        {
            AllObjects.Remove(object2D);
        }


    }
}
