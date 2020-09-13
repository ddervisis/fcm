using System;
using System.IO;

namespace FifaCareerManager.Management.IO
{
    /// <summary>
    /// Class for basic IO.
    /// </summary>
    public static class FileManagement
    {
        /// <summary>
        /// The data folder of the application, which is used to save the player data.
        /// </summary>
        private static readonly string applicationFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            AppDomain.CurrentDomain.FriendlyName
            );

        /// <summary>
        /// Open the json file of a type of players from a file on disk.
        /// </summary>
        /// <param name="playerType">The type of players.</param>
        /// <returns></returns>
        public static string OpenFile(string playerType)
        {
            string fileName = Path.Combine(applicationFolder, $@"{playerType}.json");

            if (!Directory.Exists(applicationFolder))
                Directory.CreateDirectory(applicationFolder);
            if (!File.Exists(fileName))
                File.Create(fileName).Dispose();

            return File.ReadAllText(fileName);
        }

        /// <summary>
        /// Saves the json data of a type of players to a file on disk.
        /// </summary>
        /// <param name="playerType">The type of players.</param>
        /// <param name="playerData">Data of the player type.</param>
        public static void SaveFile(string playerType, string playerData)
        {
            if (!Directory.Exists(applicationFolder))
                Directory.CreateDirectory(applicationFolder);

            File.WriteAllText(Path.Combine(applicationFolder, $@"{playerType}.json"), playerData);
        }
    }
}
