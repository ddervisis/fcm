namespace FifaCareerManager.Management.Models
{
    /// <summary>
    /// The class of a retiring player.
    /// </summary>
    /// <inheritdoc/>
    public class RetiringPlayer : Player
    {
        /// <summary>
        /// The season in which the player is retiring.
        /// </summary>
        public string RetiringSeason { get; set; }

        /// <summary>
        /// The league in which the player is playing in.
        /// </summary>
        public string League { get; set; }

        /// <summary>
        /// The club in which the player is playing at.
        /// </summary>
        public string Club { get; set; }

        /// <summary>
        /// The nationality of the player.
        /// </summary>
        public string Nationality { get; set; }
    }
}
