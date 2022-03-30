namespace NyaaNet;

/// <summary>
/// APIClient contains all externally invokable methods used to interact with the NYAA-API-GO.
/// </summary>
public class APIClient
{
    /// <summary>
    /// The address or "URI" of the server.
    /// </summary>
    public string ServerURI { get; set; }

    /// <summary>
    /// The APIToken or authorization token supplied by the server to allow for use of elevated API endpoints.
    /// </summary>
    public string APIToken { get; set; }

    /// <summary>
    /// Default ctor for the APIClient class.
    /// </summary>
    /// <param name="ServerURI"></param>
    /// <param name="APIToken"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public APIClient(string ServerURI, string APIToken)
    {
        this.ServerURI = ServerURI ?? throw new ArgumentNullException(nameof(ServerURI));
        this.APIToken = APIToken ?? throw new ArgumentNullException(nameof(APIToken));
        if (this.ServerURI.EndsWith("/")) // strip '/' from rnd of URI to prevent URI mutilation.
            // Typically I would remove the ending '/' char like this `ServerURI = ServerURI.Substring(0, ServerURI.Length - 1);` but VS suggested this unreadable cleaner way.
            this.ServerURI = this.ServerURI[..(ServerURI.Length - 1)]; 
    }


}
