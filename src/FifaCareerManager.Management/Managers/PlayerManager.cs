/// Not completely in use yet.

using System.Collections.Generic;
using FifaCareerManager.Management.IO;
using FifaCareerManager.Management.Serializers;

namespace FifaCareerManager.Management.Managers
{
    /// <summary>
    /// The class for managing players.
    /// </summary>
    public class PlayerManager<T>
    {
        /// <summary>
        /// The list of players.
        /// </summary>
        public List<T> PlayerList { get; }

        /// <summary>
        /// Create a new player manager.
        /// </summary>
        public PlayerManager()
        {
            PlayerList = GetPlayers(typeof(T).Name);
        }

        /// <summary>
        /// Create a new player manager.
        /// </summary>
        /// <param name="players">A list of players.</param>
        public PlayerManager(List<T> players)
        {
            PlayerList = players;
        }

        /// <summary>
        /// Retrieves the players.
        /// </summary>
        /// <typeparam name="T">The specific type of player</typeparam>
        /// <returns>A <typeparamref name="T"/> representation of the JSON value.</returns>
        private static List<T> GetPlayers(string playerType)
        {
            var jsonString = FileManagement.OpenFile(playerType);
            if (!string.IsNullOrWhiteSpace(jsonString))
            {
                return PlayerSerializer.DeserializePlayers<List<T>>(jsonString);
            }
            return new List<T>();
        }

        /// <summary>
        /// Adds a player to the <paramref name="PlayerList"/>
        /// </summary>
        /// <param name="player">The player to add to the <paramref name="PlayerList"/></param>
        /// <returns>True, if the addition is successful, otherwise False.</returns>
        public bool AddPlayer(T player)
        {
            if (!PlayerList.Contains(player))
            {
                PlayerList.Add(player);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes the first occurence of a specific <paramref name="player"/> from the <paramref name="PlayerList"/>.
        /// </summary>
        /// <param name="player">The player to remove from the <paramref name="PlayerList"/></param>
        /// <returns>true if <paramref name="player"/> is successfully removed; otherwise, false. This method also returns false if <paramref name="player"/> was not found in the <paramref name="PlayerList"/>.</returns>
        public bool RemovePlayer(T player)
        {
            if (PlayerList.Contains(player))
            {
                PlayerList.Remove(player);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Updates an existing player in the <paramref name="PlayerList"/> with a new player.
        /// </summary>
        /// <param name="oldPlayer">The existing player who should be replaced.</param>
        /// <param name="newPlayer">A new player to replace the <paramref name="oldPlayer"/>.</param>
        /// <returns>true, if the update is successful; otherwise, false.</returns>
        public bool UpdatePlayer(T oldPlayer, T newPlayer)
        {
            if (PlayerList.Contains(oldPlayer))
            {
                PlayerList[
                    PlayerList.FindIndex(index => index.Equals(oldPlayer))
                ] = newPlayer;
                return true;
            }
            return false;
        }
    }
}
