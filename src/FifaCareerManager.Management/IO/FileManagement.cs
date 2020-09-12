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
        static readonly string applicationFolder = Path.Combine(
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
            try
            {
                if (!Directory.Exists(applicationFolder))
                {
                    Directory.CreateDirectory(applicationFolder);
                }
                return File.ReadAllText(Path.Combine(applicationFolder, $@"{playerType}.json"));
            }
            catch (FileNotFoundException)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Saves the json data of a type of players to a file on disk.
        /// </summary>
        /// <param name="playerType">The type of players.</param>
        /// <param name="playerData">Data of the player type.</param>
        public static void SaveFile(string playerType, string playerData)
        {
            if (!Directory.Exists(applicationFolder))
            {
                Directory.CreateDirectory(applicationFolder);
            }
            File.WriteAllText(Path.Combine(applicationFolder, $@"{playerType}.json"), playerData);
        }
    }
}
