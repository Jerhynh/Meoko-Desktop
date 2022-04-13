using NyaaNet.Models;
using System.Text.Json;

namespace NyaaNet
{
    /// <summary>
    /// A slew of helper methods to help with parsing results returned from the Nyaa API.
    /// </summary>
    public class JsonHelpers
    {
        /// <summary>
        /// Deserialize a json string to a list of NyaaPost objects.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Nullable list of NyaaPost objects.</returns>
        public static List<NyaaPost>? DeserializeResults(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<List<NyaaPost>>(json);
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
