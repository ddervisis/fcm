using System.Text.Json.Serialization;
using FifaCareerManager.Management.Mappings;

namespace FifaCareerManager.Management.Models
{
    /// <summary>
    /// The player base class.
    /// Contains basic properties of a player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The position the player is playing in.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PositionMapping.Position Position { get; set; }
    }
}
