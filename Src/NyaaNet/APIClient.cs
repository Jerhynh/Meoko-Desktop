using NyaaNet.Enums;

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
        public string? ServerURI { get; set; }

        /// <summary>
        /// The authentication method to be utilized when contacting the API server.
        /// </summary>
        private AuthMethod ClientAuthMethod { get; set; }

        /// <summary>
        /// The username to be used when connecting via BasicAuth
        /// </summary>
        private string? Username { get; set; }

        /// <summary>
        /// The password to be used when connecting via BasicAuth
        /// </summary>
        private string? Password { get; set; }


        /// <summary>
        /// The APIToken or authorization token supplied by the server in API key configurations to allow authenticated use of API endpoints.
        /// </summary>
        public string? APIToken { get; set; }

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
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));

            if (ServerURI.EndsWith("/")) // strip '/' from rnd of URI to prevent URI mutilation.
                ServerURI = ServerURI[..(ServerURI.Length - 1)];
            ClientAuthMethod = AuthMethod.BasicAuthentication;
        }

    }
}