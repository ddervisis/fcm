using System.Text.Json;

namespace FifaCareerManager.Management.Serializers
{
    /// <summary>
    /// Class to de- or serialize players from or into JSON.
    /// </summary>
    public static class PlayerSerializer
    {
        /// <summary>
        /// The options used for the JSON de- and serialization.
        /// </summary>
        static readonly JsonSerializerOptions serializationOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        /// <summary>
        /// Converts the value of a type specified by a generic type parameter into a JSON string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="players"></param>
        /// <returns>A JSON representation of the value</returns>
        public static string SerializePlayers<T>(T players)
        {
            return JsonSerializer.Serialize(players, serializationOptions);
        }

        /// <summary>
        /// Parses the text representing a single JSON value into an instance if the type specified by a generic type parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonInput"></param>
        /// <returns>A <typeparamref name="T"/> representation of the JSON value.</returns>
        public static T DeserializePlayers<T>(string jsonInput)
        {
            return JsonSerializer.Deserialize<T>(jsonInput, serializationOptions);
        }
    }
}
