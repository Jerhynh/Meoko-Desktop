using NyaaNet.Enums;
using System.Net.Http.Headers;
using System.Text;

namespace NyaaNet
{
    /// <summary>
    /// APIClient contains all externally invokable methods used to interact with the NYAA-API-GO.
    /// </summary>
    public class APIClient
    {
        /// <summary>
        /// The address or "URI" of the server.
        /// </summary>
        internal static string? ServerURI { get; set; }

        /// <summary>
        /// The authentication method to be utilized when contacting the API server.
        /// </summary>
        internal static AuthMethod ClientAuthMethod { get; set; }

        /// <summary>
        /// The credential header to be attached to Basic Authentication requests.
        /// </summary>
        internal static string? AuthHeaderCredential { get; set; }


        /// <summary>
        /// The APIToken or authorization token supplied by the server in API key configurations to allow authenticated use of API endpoints.
        /// </summary>
        internal static string? APIToken { get; set; }

        /// <summary>
        /// BasicAuth constructor for the APIClient class.
        /// </summary>
        /// <param name="serverURI">URL or contact address of the server.</param>
        /// <param name="username">Account Username</param>
        /// <param name="password">Account Password</param>
        /// <exception cref="ArgumentNullException">A provided argument was null.</exception>
        public APIClient(string serverURI, string username, string password)
        {
            ServerURI = serverURI ?? throw new ArgumentNullException(nameof(serverURI));
            string user = username ?? throw new ArgumentNullException(nameof(username));
            string pass = password ?? throw new ArgumentNullException(nameof(password));

            // Here we build our AuthHeader for BasicAuth requests.
            AuthHeaderCredential = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{pass}"));

            if (ServerURI.EndsWith("/")) // strip '/' from rnd of URI to prevent URI mutilation.
                ServerURI = ServerURI[..(ServerURI.Length - 1)];
            ClientAuthMethod = AuthMethod.BasicAuthentication;
        }

        /// <summary>
        /// Querys the server's health endpoint. (Note): It is reccomended to call this upon startup to validate configuration.
        /// </summary>
        /// <returns>A response indicating whether the server is healthy and alive or not.</returns>
        /// <exception cref="HttpRequestException">The server replied to the request with a non-success status code.</exception>
        public async Task<string> HealthCheckAsync()
        {
            using var client = new HttpClient();
            var url = $"{ServerURI}/";
            if (ClientAuthMethod == AuthMethod.BasicAuthentication)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", AuthHeaderCredential);
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

    }
}