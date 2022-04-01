namespace NyaaNet.Enums
{
    /// <summary>
    /// Enum representing all callable API endpoints.
    /// </summary>
    public enum RouteEndpoints
    {
        /// <summary>
        /// Returns all content types.
        /// </summary>
        All = 0,

        /// <summary>
        /// Returns only items matching the Anime content type.
        /// </summary>
        Anime = 1,

        /// <summary>
        /// Returns only items matching the Manga content type.
        /// </summary>
        Manga = 2,

        /// <summary>
        /// Returns only items matching the Audio content type.
        /// </summary>
        Audio = 3,

        /// <summary>
        /// Returns only items matching the Pictures content type.
        /// </summary>
        Pictures = 4,

        /// <summary>
        /// Returns only items matching the LiveAction content type.
        /// </summary>
        LiveAction = 5,

        /// <summary>
        /// Returns only items matching the Software content type.
        /// </summary>
        Software = 6,

        /// <summary>
        /// Returns only items matching the ID content type.
        /// </summary>
        ID = 7,

        /// <summary>
        /// Returns only items matching the User content type.
        /// </summary>
        User = 8,
    }
}
