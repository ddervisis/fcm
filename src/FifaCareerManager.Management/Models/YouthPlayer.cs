namespace FifaCareerManager.Management.Models
{
    /// <summary>
    /// The class of a scouted youth player.
    /// </summary>
    /// <inheritdoc/>
    public class YouthPlayer : Player
    {
        /// <summary>
        /// The minimum overall rating of the player.
        /// </summary>
        public int MinRating { get; set; }

        /// <summary>
        /// The maximum overall rating of the player.
        /// </summary>
        public int MaxRating { get; set; }

        /// <summary>
        /// The minimum potential of the player.
        /// </summary>
        public int MinPotential { get; set; }

        /// <summary>
        /// The maximum potential of the player.
        /// </summary>
        public int MaxPotential { get; set; }
    }
}
